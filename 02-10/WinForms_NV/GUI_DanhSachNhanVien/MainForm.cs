using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO_QuanLyNhanVien;
using BUS_QuanLyNhanVien;
using System.Globalization;

namespace GUI_NhanVien
{
    public partial class MainForm : Form
    {
        private BUS_NhanVien busNhanVien;

        public MainForm()
        {
            InitializeComponent();
            busNhanVien = new BUS_NhanVien();
        }
        List<NhanVien> danhSachNhanVien;
        private void RefreshDanhSachNhanVien()
        {
            danhSachNhanVien = busNhanVien.LayDanhSachNhanVien();
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = danhSachNhanVien;
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien()
            {
                MaNhanVien = txtMaNhanVien.Text,
                TenNhanVien = txtTenNhanVien.Text,
                NgaySinh = dtpNgaySinh.Value,
                Email = txtEmail.Text,
                SDT = txtSDT.Text,
                DiaChi = txtDiaChi.Text
            };

            // Kiểm tra hợp lệ trước khi thêm
            if (ValidateNhanVien(nhanVien) == true && ValidateMaNhanVien(nhanVien) == true)
            {
                busNhanVien.ThemNhanVien(nhanVien);
                RefreshDanhSachNhanVien();
                ClearTextBoxes();
            }
        }


        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNhanVien.Text;

            // Gọi phương thức xóa Nhân viên từ lớp BUS_NhanVien
            busNhanVien.XoaNhanVien(maNhanVien);

            // Cập nhật DataGridView sau khi xóa
            RefreshDanhSachNhanVien();

            ClearTextBoxes();
        }


        private void ClearTextBoxes()
        {
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtEmail.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một ô bất kỳ trong DataGridView chưa
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy thông tin từ dòng được chọn
                DataGridViewRow selectedRow = dgvNhanVien.Rows[e.RowIndex];

                // Lấy giá trị từ các ô trong dòng và hiển thị lên các TextBox
                txtMaNhanVien.Text = selectedRow.Cells["MaNhanVien"].Value.ToString();
                txtTenNhanVien.Text = selectedRow.Cells["TenNhanVien"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtSDT.Text = selectedRow.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();

                // Lấy giá trị ngày sinh từ cột "NgaySinh" và gán cho DateTimePicker
                if (selectedRow.Cells["NgaySinh"].Value != null)
                {
                    DateTime ngaySinh = (DateTime)selectedRow.Cells["NgaySinh"].Value;
                    dtpNgaySinh.Value = ngaySinh;
                }
                else
                {
                    // Đặt DateTimePicker về giá trị mặc định nếu ngày sinh không có giá trị
                    dtpNgaySinh.Value = DateTime.Now;
                }
            }
        }


        private bool isEditing = false; // Sử dụng biến này để theo dõi trạng thái hiển thị/cập nhật

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                // Kiểm tra xem có dòng nào được chọn trong DataGridView không
                if (dgvNhanVien.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn Nhân viên cần sửa hoặc dữ liệu trống.");
                    return;
                }

                // Lấy thông tin Nhân viên cần sửa từ ô được chọn
                DataGridViewCell selectedCell = dgvNhanVien.SelectedCells[0];
                DataGridViewRow selectedRow = selectedCell.OwningRow;
                string maNhanVien = selectedRow.Cells["MaNhanVien"].Value.ToString();

                // Trạng thái hiển thị thông tin Nhân viên
                txtMaNhanVien.Text = maNhanVien;
                txtTenNhanVien.Text = selectedRow.Cells["TenNhanVien"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtSDT.Text = selectedRow.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();

                if (selectedRow.Cells["NgaySinh"].Value != null)
                {
                    DateTime ngaySinh = (DateTime)selectedRow.Cells["NgaySinh"].Value;
                    dtpNgaySinh.Value = ngaySinh;
                }
                else
                {
                    dtpNgaySinh.Value = DateTime.Now;
                }

                // Chuyển sang trạng thái cập nhật thông tin Nhân viên
                isEditing = true;
                txtMaNhanVien.Enabled = false;
            }
            else
            {
                // Trạng thái cập nhật thông tin Nhân viên
                string maNhanVien = txtMaNhanVien.Text;
                string tenNhanVien = txtTenNhanVien.Text;
                DateTime ngaySinh = dtpNgaySinh.Value;
                string email = txtEmail.Text;
                string sdt = txtSDT.Text;
                string diaChi = txtDiaChi.Text;

                NhanVien nhanVienMoi = new NhanVien()
                {
                    MaNhanVien = maNhanVien,
                    TenNhanVien = tenNhanVien,
                    NgaySinh = ngaySinh,
                    Email = email,
                    SDT = sdt,
                    DiaChi = diaChi
                };

                if (ValidateNhanVien(nhanVienMoi))
                {
                    busNhanVien.CapNhatThongTinNhanVien(nhanVienMoi);
                    RefreshDanhSachNhanVien();
                    MessageBox.Show("Cập nhật thông tin Nhân viên thành công.");
                    ClearTextBoxes();
                    isEditing = false;
                    txtMaNhanVien.Enabled = true;
                }
            }
        }

        private bool ValidateMaNhanVien(NhanVien nhanVien)
        {
            // Kiểm tra Mã nhân viên không được null hoặc rỗng
            if (string.IsNullOrEmpty(nhanVien.MaNhanVien))
            {
                MessageBox.Show("Mã nhân viên không được để trống.");
                return false;
            }

            // Kiểm tra xem Mã nhân viên đã tồn tại trong danh sách hay chưa
            if (danhSachNhanVien.Any(nv => nv.MaNhanVien == nhanVien.MaNhanVien))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại.");
                return false;
            }

            return true;
        }

        private bool ValidateNhanVien(NhanVien nhanVien)
        {
            // Kiểm tra Ngày sinh không được lớn hơn hiện tại
            if (nhanVien.NgaySinh > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại.");
                return false;
            }

            // Kiểm tra Email phải có định dạng @gmail.com
            if (!nhanVien.Email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email phải có định dạng @gmail.com.");
                return false;
            }

            // Kiểm tra Số điện thoại phải có đúng 10 số hoặc không cần điền
            string cleanedSDT = new string(nhanVien.SDT.Where(char.IsDigit).ToArray());
            if (string.IsNullOrEmpty(cleanedSDT) || cleanedSDT.Length == 10)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 số hoặc để trống.");
                return false;
            }

            return true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            RefreshDanhSachNhanVien();
        }



    }
}

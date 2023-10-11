using BLL;
using DAL; // Import DAL
using DTO; // Import DTO
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UC_NhanVien : UserControl
    {

        private NhanVienBLL danhSachNhanVien = new NhanVienBLL();


        public UC_NhanVien()
        {
            InitializeComponent();
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.AutoGenerateColumns = false;
            LoadDataToGridView();
        }
        private void LoadDataToGridView()
        {
            dgvNhanVien.DataSource = danhSachNhanVien.GetAllNhanVien();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox và DateTimePicker
            string maNhanVien = txtMaNhanVien.Text;
            string tenNhanVien = txtTenNhanVien.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;

            // Tạo một đối tượng NhanVienDTO
            NhanVienDTO nhanVien = new NhanVienDTO
            {
                MaNhanVien = maNhanVien,
                TenNhanVien = tenNhanVien,
                NgaySinh = ngaySinh,
                Email = email,
                SDT = sdt,
                DiaChi = diaChi
            };

            // Kiểm tra xem thông tin hợp lệ
            if (ValidateNhanVien(nhanVien) && ValidateMaNhanVien(nhanVien))
            {
                // Gọi BLL để thêm nhân viên
                danhSachNhanVien.AddNhanVien(nhanVien);

                // Cập nhật DataGridView
                LoadDataToGridView();

                // Xóa thông tin trên các TextBox sau khi thêm
                ClearTextBoxes();
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dgvNhanVien.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn Nhân viên cần xóa hoặc dữ liệu trống.");
                return;
            }

            // Lấy mã Nhân viên của dòng được chọn
            DataGridViewRow selectedRow = dgvNhanVien.CurrentRow;
            string maNhanVien = (selectedRow.Cells["MaNhanVien"].Value ?? string.Empty).ToString();
            if (!string.IsNullOrEmpty(maNhanVien))
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa Nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra kết quả người dùng chọn
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        danhSachNhanVien.DeleteNhanVien(maNhanVien);
                        LoadDataToGridView();
                        MessageBox.Show("Xóa Nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Xóa không thành công, hiển thị thông báo lỗi và ghi log ngoại lệ (nếu cần)
                        MessageBox.Show("Xóa Nhân viên không thành công. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Ghi log ngoại lệ
                        // Logger.Log(ex);
                    }
                }
            }
        }

        private bool isEditing = false; // Biến trạng thái chỉnh sửa

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                // Trạng thái "lấy thông tin từ data đổ xuống grid"
                isEditing = true;
                txtMaNhanVien.Enabled = false;

                // Lấy thông tin từ dòng được chọn trong DataGridView và đổ vào các TextBox
                DataGridViewRow selectedRow = dgvNhanVien.CurrentRow;
                if (selectedRow != null)
                {
                    txtMaNhanVien.Text = selectedRow.Cells["MaNhanVien"].Value.ToString();
                    txtTenNhanVien.Text = selectedRow.Cells["TenNhanVien"].Value.ToString();
                    dtpNgaySinh.Value = Convert.ToDateTime(selectedRow.Cells["NgaySinh"].Value);
                    txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                    txtSDT.Text = selectedRow.Cells["SDT"].Value.ToString();
                    txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                }
            }
            else
            {
                // Trạng thái "cập nhật data lại cho datagridview"
                // Lấy thông tin từ các controls nhập liệu
                string maNhanVien = txtMaNhanVien.Text;
                string tenNhanVien = txtTenNhanVien.Text;
                DateTime ngaySinh = dtpNgaySinh.Value;
                string email = txtEmail.Text;
                string sdt = txtSDT.Text;
                string diaChi = txtDiaChi.Text;

                // Tạo đối tượng NhanVienDTO từ thông tin đã nhập
                NhanVienDTO nhanVienMoi = new NhanVienDTO()
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
                    // Thực hiện cập nhật thông tin Nhân viên
                    danhSachNhanVien.UpdateNhanVien(nhanVienMoi);
                    LoadDataToGridView();
                    ClearTextBoxes();
                    MessageBox.Show("Cập nhật thành công!");

                    // Trả về trạng thái ban đầu
                    isEditing = false;
                    txtMaNhanVien.Enabled = true;
                }
            }
        }

        private void ClearTextBoxes()
        {
            // Xóa thông tin trên các TextBox
            txtMaNhanVien.Text = string.Empty;
            txtTenNhanVien.Text = string.Empty;
            dtpNgaySinh.Value = DateTime.Now;
            txtEmail.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvNhanVien.CurrentRow;
            if (dr != null)
            {
                // Lấy thông tin từ dòng được chọn và đổ vào các TextBox
                txtMaNhanVien.Text = (dr.Cells["MaNhanVien"].Value ?? string.Empty).ToString();
                txtTenNhanVien.Text = (dr.Cells["TenNhanVien"].Value ?? string.Empty).ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(dr.Cells["NgaySinh"].Value ?? DateTime.Now);
                txtEmail.Text = (dr.Cells["Email"].Value ?? string.Empty).ToString();
                txtSDT.Text = (dr.Cells["SDT"].Value ?? string.Empty).ToString();
                txtDiaChi.Text = (dr.Cells["DiaChi"].Value ?? string.Empty).ToString();
            }
            else
            {

            }
        }

        private bool ValidateMaNhanVien(NhanVienDTO nhanVien)
        {
            // Kiểm tra Mã nhân viên không được null hoặc rỗng
            if (string.IsNullOrEmpty(nhanVien.MaNhanVien))
            {
                MessageBox.Show("Mã nhân viên không được để trống.");
                return false;
            }

            // Lấy danh sách nhân viên từ danhSachNhanVien
            List<NhanVienDTO> danhSachNhanVien = this.danhSachNhanVien.GetAllNhanVien();

            // Kiểm tra xem Mã nhân viên đã tồn tại trong danh sách hay chưa
            if (danhSachNhanVien.Any(nv => nv.MaNhanVien == nhanVien.MaNhanVien))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại.");
                return false;
            }

            return true;
        }

        private bool ValidateNhanVien(NhanVienDTO nhanVien)
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

            // Kiểm tra Số điện thoại
            string sdt = txtSDT.Text.Trim();
            if (!string.IsNullOrEmpty(sdt))
            {
                if (sdt.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải có đúng 10 số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!Regex.IsMatch(sdt, @"^\d+$"))
                {
                    MessageBox.Show("Số điện thoại chỉ được chứa ký tự số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // Nếu không có lỗi, trả về true để xác nhận thông tin hợp lệ
            return true;
        }

        private void dgvNhanVien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Lấy số thứ tự của hàng (bắt đầu từ 1)
            int rowIndex = e.RowIndex + 1;

            // Tạo một brush để vẽ số thứ tự
            using (SolidBrush brush = new SolidBrush(dgvNhanVien.RowHeadersDefaultCellStyle.ForeColor))
            {
                // Xác định vị trí để vẽ số thứ tự trên hàng tiêu đề
                float x = e.RowBounds.Left + 10; // Điều chỉnh vị trí xuất phát theo ý muốn
                float y = e.RowBounds.Top + (e.RowBounds.Height - e.InheritedRowStyle.Font.Height) / 2;

                // Vẽ số thứ tự
                e.Graphics.DrawString(rowIndex.ToString(), e.InheritedRowStyle.Font, brush, x, y);
            }
        }
    }
}

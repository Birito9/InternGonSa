﻿using BLL;
using DTO;
using Newtonsoft.Json;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace GUI
{
    public partial class UC_NhanVien : UserControl
    {
        private NhanVienBLL BLLNhanVien;
        private List<NhanVienDTO> danhSachNhanVien;
        public UC_NhanVien()
        {
            InitializeComponent();
            BLLNhanVien = new NhanVienBLL();

            // Khởi tạo
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Adddatasample();
            LoadDanhSachNhanVien();

        }
        private void Adddatasample()
        {
            // Tạo một danh sách chứa thông tin của các Nhân viên mẫu
            List<NhanVienDTO> danhSachNhanVienMau = new List<NhanVienDTO>
            {
                new NhanVienDTO()
                {
                    MaNhanVien = "NV005",
                    TenNhanVien = "Nguyễn Văn A",
                    NgaySinh = new DateTime(1990, 1, 15),
                    Email = "nguyenvana@gmail.com",
                    SDT = "0123456789",
                    DiaChi = "123 Đường ABC, Quận XYZ"
                },
                new NhanVienDTO()
                {
                    MaNhanVien = "NV006",
                    TenNhanVien = "Trần Thị B",
                    NgaySinh = new DateTime(1995, 5, 20),
                    Email = "tranthib@gmail.com",
                    SDT = "0987654321",
                    DiaChi = "456 Đường XYZ, Quận ABC"
                },
                new NhanVienDTO()
                {
                    MaNhanVien = "NV007",
                    TenNhanVien = "Lê Văn C",
                    NgaySinh = new DateTime(1988, 8, 8),
                    Email = "levanc@gmail.com",
                    SDT = "0369852147",
                    DiaChi = "789 Đường DEF, Quận UVW"
                },
                new NhanVienDTO()
                {
                    MaNhanVien = "NV008",
                    TenNhanVien = "Phạm Thị D",
                    NgaySinh = new DateTime(1993, 3, 10),
                    Email = "phamthid@gmail.com",
                    SDT = "0765432190",
                    DiaChi = "101 Đường MNO, Quận PQR"
                }
            };

            // Lặp qua danh sách Nhân viên mẫu và thêm từng Nhân viên vào danh sách chính và cơ sở dữ liệu
            foreach (NhanVienDTO nhanVienMau in danhSachNhanVienMau)
            {
                BLLNhanVien.ThemNhanVien(nhanVienMau);
            }

            // Cập nhật danh sách và xóa nội dung các trường nhập liệu
            LoadDanhSachNhanVien();
            ClearTextBoxes();

        }

        private void LoadDanhSachNhanVien()
        {
            danhSachNhanVien = BLLNhanVien.LayDanhSachNhanVien();
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = danhSachNhanVien;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
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

            // Kiểm tra hợp lệ trước khi thêm
            if (ValidateNhanVien(nhanVienMoi) == true && ValidateMaNhanVien(nhanVienMoi) == true)
            {
                // Thực hiện thêm Nhân viên vào danh sách và cơ sở dữ liệu
                BLLNhanVien.ThemNhanVien(nhanVienMoi);
                LoadDanhSachNhanVien();
                ClearTextBoxes();
                MessageBox.Show("thêm Nhân viên thành công!");
            }

        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dgvNhanVien.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn Nhân viên cần xóa hoặc dữ liệu trống.");
                return;
            }

            // Lấy mã Nhân viên của dòng được chọn
            DataGridViewRow selectedRow = dgvNhanVien.CurrentRow;
            string maNhanVien = (selectedRow.Cells[0].Value ?? string.Empty).ToString();
            if (!string.IsNullOrEmpty(maNhanVien))
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa Nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra kết quả người dùng chọn
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        BLLNhanVien.XoaNhanVien(maNhanVien);
                        LoadDanhSachNhanVien();
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

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
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
                    txtMaNhanVien.Text = selectedRow.Cells[0].Value.ToString();
                    txtTenNhanVien.Text = selectedRow.Cells[1].Value.ToString();
                    dtpNgaySinh.Value = Convert.ToDateTime(selectedRow.Cells[2].Value);
                    txtEmail.Text = selectedRow.Cells[3].Value.ToString();
                    txtSDT.Text = selectedRow.Cells[4].Value.ToString();
                    txtDiaChi.Text = selectedRow.Cells[5].Value.ToString();
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
                    BLLNhanVien.CapNhatThongTinNhanVien(nhanVienMoi);
                    LoadDanhSachNhanVien();
                    ClearTextBoxes();
                    MessageBox.Show("Cập nhật thành công!");

                    // Trả về trạng thái ban đầu
                    isEditing = false;
                    txtMaNhanVien.Enabled = true;
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo một số ngẫu nhiên từ 1000 đến 99999
                Random random = new Random();
                int randomNumber = random.Next(1000, 99999);

                // Tạo tên tệp Excel với số ngẫu nhiên
                string tenTepExcel = $"DanhSachNhanVien_{randomNumber}.xlsx";

                // Khung hộp thoại cho phép người dùng chọn nơi lưu tệp
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.FileName = tenTepExcel;
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tenTepExcel = saveFileDialog.FileName;

                    // Tạo một ExcelPackage
                    using (var package = new ExcelPackage())
                    {
                        // Tạo một Sheet có tên là "DanhSachNhanVien"
                        var worksheet = package.Workbook.Worksheets.Add("DanhSachNhanVien");

                        // Đặt tiêu đề cho các cột (hàng đầu tiên)
                        for (int col = 1; col <= dgvNhanVien.Columns.Count; col++)
                        {
                            worksheet.Cells[1, col].Value = dgvNhanVien.Columns[col - 1].HeaderText;
                        }

                        // Đặt hàng thứ hai là định dạng DataPropertyName
                        for (int col = 1; col <= dgvNhanVien.Columns.Count; col++)
                        {
                            worksheet.Cells[2, col].Value = dgvNhanVien.Columns[col - 1].DataPropertyName;
                        }

                        // Đặt kiểu định dạng cho hàng tiêu đề
                        using (var range = worksheet.Cells["A1:F2"])
                        {
                            range.Style.Font.Bold = true;
                            range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                            range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Gray);
                            range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                        }

                        // Đổ dữ liệu từ DataGridView vào Excel bắt đầu từ hàng thứ ba
                        for (int row = 0; row < dgvNhanVien.Rows.Count; row++)
                        {
                            for (int col = 0; col < dgvNhanVien.Columns.Count; col++)
                            {
                                if (dgvNhanVien.Columns[col].DataPropertyName == "NgaySinh")
                                {
                                    // Định dạng ngày tháng là "dd/MM/yyyy"
                                    worksheet.Cells[row + 3, col + 1].Value = DateTime.Parse(dgvNhanVien.Rows[row].Cells[col].Value.ToString()).ToString("dd/MM/yyyy");
                                }
                                else
                                {
                                    worksheet.Cells[row + 3, col + 1].Value = dgvNhanVien.Rows[row].Cells[col].Value.ToString();
                                }
                            }
                        }

                        // Lưu file Excel với tên tệp đã chọn
                        var file = new FileInfo(tenTepExcel);
                        package.SaveAs(file);
                        MessageBox.Show("Xuất dữ liệu thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                // Khung hộp thoại cho phép người dùng chọn tệp Excel để nhập
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Tạo một ExcelPackage từ tệp Excel đã chọn
                    using (var package = new ExcelPackage(new FileInfo(filePath)))
                    {
                        // Chọn sheet bạn muốn đọc dữ liệu từ đó
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                        // Lấy số dòng và số cột trong sheet
                        int rowCount = worksheet.Dimension.Rows;
                        int colCount = worksheet.Dimension.Columns;

                        // Duyệt qua từng dòng trong sheet và đưa dữ liệu vào danh sách hiện có
                        for (int row = 3; row <= rowCount; row++) // Bắt đầu từ hàng thứ ba 
                        {
                            NhanVienDTO nhanVien = new NhanVienDTO();
                            nhanVien.MaNhanVien = worksheet.Cells[row, 1].Value.ToString();
                            nhanVien.TenNhanVien = worksheet.Cells[row, 2].Value.ToString();
                            nhanVien.NgaySinh = DateTime.ParseExact(worksheet.Cells[row, 3].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            nhanVien.Email = worksheet.Cells[row, 4].Value.ToString();
                            nhanVien.SDT = worksheet.Cells[row, 5].Value.ToString();
                            nhanVien.DiaChi = worksheet.Cells[row, 6].Value.ToString();

                            // Thêm nhanVien vào danh sách hiện có
                            danhSachNhanVien.Add(nhanVien);
                        }

                        // Cập nhật DataGridView
                        dgvNhanVien.DataSource = null;
                        dgvNhanVien.DataSource = danhSachNhanVien;

                        MessageBox.Show("Nhập dữ liệu từ tệp Excel thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nhập dữ liệu từ tệp Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXuatJs_Click(object sender, EventArgs e)
        {
            // Khung hộp thoại cho phép người dùng chọn nơi lưu tệp JSON
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files|*.json";
            saveFileDialog.InitialDirectory = System.IO.Path.GetDirectoryName(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            saveFileDialog.FileName = "ListNhanVien.json";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string tenTepJSON = saveFileDialog.FileName;
                LuuDanhSachNhanVienSangJSON(tenTepJSON);
            }
        }

        private void ClearTextBoxes()
        {
            // Xóa nội dung các controls nhập liệu
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtEmail.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvNhanVien.CurrentRow;
            if (dr != null)
            {
                // Lấy thông tin từ dòng được chọn và đổ vào các TextBox
                txtMaNhanVien.Text = (dr.Cells[0].Value ?? string.Empty).ToString();
                txtTenNhanVien.Text = (dr.Cells[1].Value ?? string.Empty).ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(dr.Cells[2].Value ?? DateTime.Now);
                txtEmail.Text = (dr.Cells[3].Value ?? string.Empty).ToString();
                txtSDT.Text = (dr.Cells[4].Value ?? string.Empty).ToString();
                txtDiaChi.Text = (dr.Cells[5].Value ?? string.Empty).ToString();
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

        private void LuuDanhSachNhanVienSangJSON(string tenTepJSON)
        {
            if (danhSachNhanVien != null)
            {
                try
                {
                    // Chuyển danh sách Nhân viên thành chuỗi JSON
                    string json = JsonConvert.SerializeObject(danhSachNhanVien, Formatting.Indented);

                    // Lưu chuỗi JSON vào tệp
                    System.IO.File.WriteAllText(tenTepJSON, json);
                    MessageBox.Show("Lưu dữ liệu thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu dữ liệu dưới dạng JSON: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using OfficeOpenXml;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WebAPI.Models;
using Microsoft.Extensions.Configuration;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GUI
{
    public partial class UC_NhanVien : UserControl
    {
        private string apiUrl = "https://localhost:7126/api/NhanVien";
        private RestClient restClient = new RestClient();

        public UC_NhanVien()
        {
            InitializeComponent();
            LoadDanhSachNhanVien();  // Lấy danh sách nhân viên ngay khi form được khởi tạo
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Thêm các mục lựa chọn vào ComboBox
            cbxChucVu.Items.Add("Backend");
            cbxChucVu.Items.Add("Frontend");
            cbxChucVu.Items.Add("Teamlead");

            // Chọn mục đầu tiên là "Backend"
            cbxChucVu.SelectedIndex = 0;

            // Thiết lập ComboBox là Read-Only
            cbxChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void LoadDanhSachNhanVien()
        {
            var danhSachNhanVien = await LayDanhSachNhanVien();
            dgvNhanVien.DataSource = danhSachNhanVien;
            // Đảm bảo cột NgaySinh của DataGridView sử dụng kiểu DateTime
            dgvNhanVien.Columns["NgaySinh"].ValueType = typeof(DateTime);
            dgvNhanVien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";


        }

        private async Task<List<NhanVien>> LayDanhSachNhanVien()
        {
            try
            {
                var request = new RestRequest(apiUrl + "/GetNV", Method.Get);
                var response = await restClient.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    var nhanViens = JsonConvert.DeserializeObject<List<NhanVien>>(response.Content);
                    return nhanViens;
                }
                else
                {
                    MessageBox.Show("Lỗi khi lấy danh sách nhân viên: " + response.ErrorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<NhanVien>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<NhanVien>();
            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các trường dữ liệu
                string maNhanVien = txtMaNhanVien.Text;
                string tenNhanVien = txtTenNhanVien.Text;
                DateTime ngaySinh = dtpNgaySinh.Value;
                string email = txtEmail.Text;
                string sdt = txtSDT.Text;
                string diaChi = txtDiaChi.Text;
                string chucVu = cbxChucVu.SelectedItem.ToString();

                // Tạo đối tượng NhanVien
                var nhanVien = new NhanVien
                {
                    MaNhanVien = maNhanVien,
                    TenNhanVien = tenNhanVien,
                    NgaySinh = ngaySinh,
                    Email = email,
                    SDT = sdt,
                    DiaChi = diaChi,
                    ChucVu = chucVu
                };

                // Kiểm tra thông tin nhân viên trước khi thêm
                if (ValidateNhanVien(nhanVien))
                {
                    // Gửi yêu cầu POST
                    var request = new RestRequest(apiUrl + "/AddCreNV", Method.Post);
                    request.AddJsonBody(new List<NhanVien> { nhanVien });

                    // Xử lý yêu cầu và hiển thị thông báo
                    var response = await restClient.ExecuteAsync(request);

                    if (response.IsSuccessful)
                    {
                        MessageBox.Show("Thêm nhân viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi thêm nhân viên: " + response.ErrorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Thông tin nhân viên không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã nhân viên từ trường dữ liệu
                var maNhanVien = txtMaNhanVien.Text;

                // Kiểm tra mã nhân viên có giá trị
                if (!string.IsNullOrEmpty(maNhanVien))
                {
                    // Gửi yêu cầu DELETE
                    var request = new RestRequest(apiUrl + $"/DeleteNV/{maNhanVien}", Method.Delete);

                    // Xử lý yêu cầu và hiển thị thông báo
                    var response = restClient.Execute(request);

                    if (response.IsSuccessful)
                    {
                        MessageBox.Show("Xóa nhân viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa nhân viên: " + response.ErrorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Mã nhân viên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isEditing = true;

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                // Bấm lần đầu (Lấy dữ liệu và hiển thị)
                txtMaNhanVien.ReadOnly = true; // Bật trạng thái chỉ đọc
                isEditing = false;
                // Lấy thông tin từ dòng được chọn trong DataGridView và đổ vào các TextBox
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
                    cbxChucVu.SelectedItem = dr.Cells[6].Value.ToString();

                }
            }
            else
            {
                // Bấm lần thứ hai (Thực hiện cập nhật)
                try
                {
                    // Lấy thông tin từ các trường dữ liệu                    
                    string tenNhanVien = txtTenNhanVien.Text;
                    DateTime ngaySinh = dtpNgaySinh.Value;
                    string email = txtEmail.Text;
                    string sdt = txtSDT.Text;
                    string diaChi = txtDiaChi.Text;
                    string chucVu = cbxChucVu.SelectedItem.ToString();

                    // Tạo đối tượng NhanVien
                    var nhanVien = new NhanVien
                    {
                        MaNhanVien = txtMaNhanVien.Text,
                        TenNhanVien = tenNhanVien,
                        NgaySinh = ngaySinh,
                        Email = email,
                        SDT = sdt,
                        DiaChi = diaChi,
                        ChucVu = chucVu
                    };

                    // Kiểm tra thông tin nhân viên trước khi sửa
                    if (ValidateNhanVien(nhanVien))
                    {
                        // Gửi yêu cầu POST
                        var request = new RestRequest(apiUrl + "/AddCreNV", Method.Post);
                        request.AddJsonBody(new List<NhanVien> { nhanVien });

                        // Xử lý yêu cầu và hiển thị thông báo
                        var response = await restClient.ExecuteAsync(request);

                        if (response.IsSuccessful)
                        {
                            MessageBox.Show("Cập nhật thông tin nhân viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachNhanVien();
                            ClearTextBoxes();
                            isEditing = true;
                            txtMaNhanVien.ReadOnly = false; // Tắt trạng thái chỉ đọc
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi cập nhật thông tin nhân viên: " + response.ErrorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thông tin nhân viên không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật thông tin nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private async void btnNhap_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Tệp Excel (*.xlsx)|*.xlsx";
                openFileDialog.Title = "Chọn tệp Excel để nhập dữ liệu";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        var configurationBuilder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json");

                        var configuration = configurationBuilder.Build();
                        string connectionString = configuration.GetConnectionString("NhanVienCS");

                        using (var package = new ExcelPackage(new FileInfo(filePath)))
                        {
                            var worksheet = package.Workbook.Worksheets[0]; // Lấy sheet đầu tiên

                            int rowCount = worksheet.Dimension.Rows;

                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();

                                for (int row = 2; row <= rowCount; row++)
                                {
                                    string maNhanVien = worksheet.Cells[row, 1].Value?.ToString();
                                    string tenNhanVien = worksheet.Cells[row, 2].Value?.ToString();
                                    DateTime ngaySinh = DateTime.ParseExact(worksheet.Cells[row, 3].Value?.ToString(), "dd/MM/yyyy", null);
                                    string email = worksheet.Cells[row, 4].Value?.ToString();
                                    string soDienThoai = worksheet.Cells[row, 5].Value?.ToString();
                                    string diaChi = worksheet.Cells[row, 6].Value?.ToString();
                                    string chucVu = worksheet.Cells[row, 7].Value?.ToString();

                                    // Trước khi thêm mới, kiểm tra xem nhân viên đã tồn tại hay chưa
                                    string checkEmployeeQuery = "SELECT COUNT(*) FROM NhanViens WHERE MaNhanVien = @MaNhanVien";
                                    SqlCommand checkCommand = new SqlCommand(checkEmployeeQuery, connection);
                                    checkCommand.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

                                    int existingEmployeeCount = (int)checkCommand.ExecuteScalar();

                                    if (existingEmployeeCount == 0)
                                    {
                                        // Nhân viên chưa tồn tại, thực hiện thêm mới
                                        string insertEmployeeQuery = "INSERT INTO NhanViens (MaNhanVien, TenNhanVien, NgaySinh, Email, SDT, DiaChi, ChucVu) " +
                                                                    "VALUES (@MaNhanVien, @TenNhanVien, @NgaySinh, @Email, @SDT, @DiaChi, @ChucVu)";

                                        SqlCommand insertCommand = new SqlCommand(insertEmployeeQuery, connection);
                                        insertCommand.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                                        insertCommand.Parameters.AddWithValue("@TenNhanVien", tenNhanVien);
                                        insertCommand.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                                        insertCommand.Parameters.AddWithValue("@Email", email);
                                        insertCommand.Parameters.AddWithValue("@SDT", soDienThoai);
                                        insertCommand.Parameters.AddWithValue("@DiaChi", diaChi);
                                        insertCommand.Parameters.AddWithValue("@ChucVu", chucVu);

                                        insertCommand.ExecuteNonQuery();
                                    }
                                    else
                                    {
                                        // Nhân viên đã tồn tại, thực hiện xử lý tương ứng (ví dụ: thông báo rằng nhân viên đã tồn tại)
                                    }
                                }

                                connection.Close();
                            }

                            MessageBox.Show("Nhập dữ liệu từ Excel và cập nhật vào cơ sở dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachNhanVien();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void btnXuat_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Tệp Excel (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Chọn nơi lưu tệp Excel xuất dữ liệu";
                saveFileDialog.FileName = "DanhSachhNhanVien.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Tạo tệp Excel mới
                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("DanhSachNhanVien");

                        // Thêm tiêu đề cột
                        for (int i = 0; i < dgvNhanVien.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dgvNhanVien.Columns[i].HeaderText;
                        }

                        // Thêm tiêu đề cột và định dạng ngày sinh
                        for (int i = 0; i < dgvNhanVien.Columns.Count; i++)
                        {
                            if (dgvNhanVien.Columns[i].Name == "NgaySinh")
                            {
                                worksheet.Cells[1, i + 1].Value = "Ngày Sinh";
                                for (int row = 0; row < dgvNhanVien.Rows.Count; row++)
                                {
                                    DateTime ngaySinh = (DateTime)dgvNhanVien.Rows[row].Cells[i].Value;
                                    worksheet.Cells[row + 2, i + 1].Value = ngaySinh.ToString("dd/MM/yyyy");
                                }
                            }
                            else
                            {
                                worksheet.Cells[1, i + 1].Value = dgvNhanVien.Columns[i].HeaderText;
                                for (int row = 0; row < dgvNhanVien.Rows.Count; row++)
                                {
                                    worksheet.Cells[row + 2, i + 1].Value = dgvNhanVien.Rows[row].Cells[i].Value;
                                }
                            }
                        }


                        // Lưu tệp Excel
                        package.SaveAs(new System.IO.FileInfo(filePath));
                    }
                }
            }
        }




        private void btnXuatJs_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy danh sách nhân viên từ DataGridView
                List<NhanVien> danhSachNhanVien = dgvNhanVien.DataSource as List<NhanVien>;

                if (danhSachNhanVien != null && danhSachNhanVien.Count > 0)
                {
                    // Chuyển danh sách nhân viên thành chuỗi JSON
                    string jsonData = System.Text.Json.JsonSerializer.Serialize(danhSachNhanVien);

                    // Đường dẫn và tên tệp JavaScript để lưu trữ dữ liệu
                    string filePath = "dulieu.js";

                    // Ghi chuỗi JSON vào tệp JavaScript
                    System.IO.File.WriteAllText(filePath, jsonData);

                    MessageBox.Show("Dữ liệu đã được xuất ra tệp JavaScript thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để xuất ra tệp JavaScript.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi xuất dữ liệu ra tệp JavaScript: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidateNhanVien(NhanVien nhanVien)
        {
            bool isValid = true; // Giả sử thông tin là hợp lệ ban đầu

            // Kiểm tra Ngày sinh không được lớn hơn hiện tại
            if (nhanVien.NgaySinh > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            // Kiểm tra Email phải có định dạng @gmail.com
            if (!nhanVien.Email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email phải kết thúc bằng '@gmail.com'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            // Kiểm tra Số điện thoại đúng 10 số và chỉ được chứa ký tự số.
            if (nhanVien.SDT.Length != 10 || !nhanVien.SDT.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số và chỉ chứa ký tự số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            return isValid;
        }


        private void ClearTextBoxes()
        {
            // Xóa nội dung các controls nhập liệu
            txtMaNhanVien.Text = string.Empty;
            txtTenNhanVien.Text = string.Empty;
            dtpNgaySinh.Value = DateTime.Now;
            txtEmail.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            cbxChucVu.SelectedIndex = 0;

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
                string chucVu = dr.Cells["ChucVu"].Value?.ToString();
                if (!string.IsNullOrEmpty(chucVu))
                {
                    switch (chucVu)
                    {
                        case "Backend":
                            cbxChucVu.SelectedItem = "Backend";
                            break;
                        case "Frontend":
                            cbxChucVu.SelectedItem = "Frontend";
                            break;
                        case "Teamlead":
                            cbxChucVu.SelectedItem = "Teamlead";
                            break;
                        default:
                            // Xử lý trường hợp khác nếu cần
                            break;
                    }
                }

            }
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

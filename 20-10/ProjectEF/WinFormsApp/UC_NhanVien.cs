using Microsoft.AspNetCore.Http.HttpResults;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using WebAPI.Models;

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

                // Tạo đối tượng NhanVien từ thông tin được nhập
                NhanVien nhanVien = new NhanVien
                {
                    MaNhanVien = maNhanVien,
                    TenNhanVien = tenNhanVien,
                    NgaySinh = ngaySinh,
                    Email = email,
                    SDT = sdt,
                    DiaChi = diaChi,
                    ChucVu = chucVu
                };

                // Tạo một danh sách NhanVien chứa đối tượng nhanVien
                List<NhanVien> danhSachNhanVien = new List<NhanVien> { nhanVien };

                // Gửi yêu cầu thêm thông tin nhân viên lên máy chủ
                var request = new RestRequest(apiUrl + "/AddCreNV", Method.Post);
                request.AddJsonBody(danhSachNhanVien);

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
                var maNhanVien = txtMaNhanVien.Text;

                var request = new RestRequest(apiUrl + $"/DeleteNV/{maNhanVien}", Method.Delete);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var nhanVienSua = new NhanVien
                {
                    TenNhanVien = txtTenNhanVien.Text,
                    NgaySinh = dtpNgaySinh.Value,
                    Email = txtEmail.Text,
                    SDT = txtSDT.Text,
                    DiaChi = txtDiaChi.Text,
                    ChucVu = cbxChucVu.SelectedItem.ToString()
                };

                var request = new RestRequest(apiUrl + "/AddCreNV", Method.Post);
                request.AddJsonBody(nhanVienSua);

                var response = restClient.Execute(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNhanVien();
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật thông tin nhân viên: " + response.ErrorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {

        }

        private void btnXuatJs_Click(object sender, EventArgs e)
        {

        }
    }
}

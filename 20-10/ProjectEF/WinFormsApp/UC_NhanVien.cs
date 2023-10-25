using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using WebAPI.Models;

namespace GUI
{
    public partial class UC_NhanVien : UserControl
    {
        private string apiUrl = "https://localhost:7126/api/NhanVien";
        private HttpClient httpClient = new HttpClient();

        public UC_NhanVien()
        {
            InitializeComponent();
            // Thiết lập sự kiện cho nút Thêm
            btnThem.Click += async (sender, e) => await ThemNhanVien();

            // Thiết lập sự kiện cho nút Xóa
            btnXoa.Click += async (sender, e) => await XoaNhanVien();

            // Thiết lập sự kiện cho nút Sửa
            btnSua.Click += async (sender, e) => await SuaNhanVien();

            // Thiết lập sự kiện cho nút Xuất Json
            btnXuatJs.Click += async (sender, e) => await XuatJsonNhanVien();
        }

        // Lấy danh sách nhân viên từ API
        private async Task<List<NhanVien>> LayDanhSachNhanVien()
        {
            try
            {
                var response = await httpClient.GetStringAsync(apiUrl);
                var nhanViens = Newtonsoft.Json.JsonConvert.DeserializeObject<List<NhanVien>>(response);
                return nhanViens;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<NhanVien>();
            }
        }

        // Thêm một nhân viên qua API
        private async Task ThemNhanVien()
        {
            // Điền thông tin nhân viên từ giao diện
            var nhanVien = new NhanVien
            {
                MaNhanVien = txtMaNhanVien.Text,
                TenNhanVien = txtTenNhanVien.Text,
                NgaySinh = dtpNgaySinh.Value,
                Email = txtEmail.Text,
                SDT = txtSDT.Text,
                DiaChi = txtDiaChi.Text,
                ChucVu = cbxChucVu.Text
            };

            // Gọi API để thêm nhân viên
            var jsonContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(nhanVien), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(apiUrl, jsonContent);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + response.ReasonPhrase, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Làm mới danh sách nhân viên
            var danhSachNhanVien = await LayDanhSachNhanVien();
            dgvNhanVien.DataSource = danhSachNhanVien;
        }

        // Xóa một nhân viên qua API
        private async Task XoaNhanVien()
        {
            // Lấy mã nhân viên từ ô nhập liệu
            var maNhanVien = txtMaNhanVien.Text;

            // Gọi API để xóa nhân viên
            var response = await httpClient.DeleteAsync($"{apiUrl}/{maNhanVien}");

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Xóa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi khi xóa nhân viên: " + response.ReasonPhrase, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Làm mới danh sách nhân viên
            var danhSachNhanVien = await LayDanhSachNhanVien();
            dgvNhanVien.DataSource = danhSachNhanVien;
        }

        // Sửa thông tin một nhân viên qua API
        private async Task SuaNhanVien()
        {
            // Điền thông tin nhân viên từ giao diện
            var nhanVien = new NhanVien
            {
                MaNhanVien = txtMaNhanVien.Text,
                TenNhanVien = txtTenNhanVien.Text,
                NgaySinh = dtpNgaySinh.Value,
                Email = txtEmail.Text,
                SDT = txtSDT.Text,
                DiaChi = txtDiaChi.Text,
                ChucVu = cbxChucVu.Text
            };

            // Gọi API để cập nhật nhân viên
            var jsonContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(nhanVien), Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync(apiUrl, jsonContent);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi khi cập nhật nhân viên: " + response.ReasonPhrase, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Làm mới danh sách nhân viên
            var danhSachNhanVien = await LayDanhSachNhanVien();
            dgvNhanVien.DataSource = danhSachNhanVien;
        }

        // Xuất thông tin một nhân viên dưới dạng JSON
        private async Task XuatJsonNhanVien()
        {
            // Lấy mã nhân viên từ ô nhập liệu
            var maNhanVien = txtMaNhanVien.Text;

            // Gọi API để lấy thông tin nhân viên dưới dạng JSON
            var response = await httpClient.GetStringAsync($"{apiUrl}/{maNhanVien}");

            if (response != null)
            {
                MessageBox.Show("Thông tin nhân viên dưới dạng JSON:\n" + response, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên hoặc có lỗi khi lấy dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

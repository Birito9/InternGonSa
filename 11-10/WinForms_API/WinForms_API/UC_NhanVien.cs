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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UC_NhanVien : UserControl
    {

        private NhanVienBLL nhanVienBLL = new NhanVienBLL();

        public UC_NhanVien()
        {
            InitializeComponent();
            dgvNhanVien.AutoGenerateColumns = false;
            LoadDataToGridView();
        }
        private void LoadDataToGridView()
        {
            dgvNhanVien.DataSource = nhanVienBLL.GetAllNhanVien();
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

            // Gọi BLL để thêm nhân viên
            nhanVienBLL.AddNhanVien(nhanVien);

            // Cập nhật DataGridView
            LoadDataToGridView();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            // Lấy mã nhân viên muốn xóa
            string maNhanVien = txtMaNhanVien.Text;

            // Gọi BLL để xóa nhân viên
            nhanVienBLL.DeleteNhanVien(maNhanVien);

            // Cập nhật DataGridView
            LoadDataToGridView();
        }

        private void BtnSua_Click(object sender, EventArgs e)
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

            // Gọi BLL để cập nhật thông tin nhân viên
            nhanVienBLL.UpdateNhanVien(nhanVien);

            // Cập nhật DataGridView
            LoadDataToGridView();
        }
    }
}

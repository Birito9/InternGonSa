using DTO.NhanVien;
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
    public partial class NhanVienForm : Form
    {
        private NhanVien nhanVien; // Đối tượng NhanVien để hiển thị

        // Các controls trên form
        private TextBox txtMaNhanVien;
        private TextBox txtTenNhanVien;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtEmail;
        private TextBox txtSdt;
        private TextBox txtDiaChi;
        private TextBox txtChucVu;
        public NhanVienForm()
        {
            InitializeComponent();

            this.nhanVien = nhanVien;

            // Khởi tạo và cấu hình các controls
            txtMaNhanVien = new TextBox();
            txtTenNhanVien = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            txtEmail = new TextBox();
            txtSdt = new TextBox();
            txtDiaChi = new TextBox();
            txtChucVu = new TextBox();

            // Đặt giá trị của các controls dựa trên dữ liệu từ đối tượng NhanVien
            txtMaNhanVien.Text = nhanVien.MaNhanVien;
            txtTenNhanVien.Text = nhanVien.TenNhanVien;
            if (nhanVien.NgaySinh.HasValue)
            {
                dtpNgaySinh.Value = nhanVien.NgaySinh.Value;
            }
            txtEmail.Text = nhanVien.Email;
            txtSdt.Text = nhanVien.Sdt;
            txtDiaChi.Text = nhanVien.DiaChi;
            txtChucVu.Text = nhanVien.ChucVu;

            // Thêm các controls vào form
            Controls.Add(txtMaNhanVien);
            Controls.Add(txtTenNhanVien);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtEmail);
            Controls.Add(txtSdt);
            Controls.Add(txtDiaChi);
            Controls.Add(txtChucVu);

            // Cấu hình kích thước và vị trí của từng control
            // ...

            // Các sự kiện và xử lý lưu dữ liệu khi người dùng thay đổi giá trị
            txtMaNhanVien.TextChanged += (sender, e) => nhanVien.MaNhanVien = txtMaNhanVien.Text;
            txtTenNhanVien.TextChanged += (sender, e) => nhanVien.TenNhanVien = txtTenNhanVien.Text;
            dtpNgaySinh.ValueChanged += (sender, e) => nhanVien.NgaySinh = dtpNgaySinh.Value;
            txtEmail.TextChanged += (sender, e) => nhanVien.Email = txtEmail.Text;
            txtSdt.TextChanged += (sender, e) => nhanVien.Sdt = txtSdt.Text;
            txtDiaChi.TextChanged += (sender, e) => nhanVien.DiaChi = txtDiaChi.Text;
            txtChucVu.TextChanged += (sender, e) => nhanVien.ChucVu = txtChucVu.Text;
        }
    }
}

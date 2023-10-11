using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallAPI
{
    public partial class UC_NhanVien : UserControl
    {
        private NhanVienDAL nhanVienDAL = new NhanVienDAL();

        public UC_NhanVien()
        {
            InitializeComponent();
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = nhanVienDAL.DocDanhSachNhanVienTuFile();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            NhanVienDTO nhanVien = new NhanVienDTO
            {
                MaNhanVien = txtMaNhanVien.Text,
                TenNhanVien = txtTenNhanVien.Text,
                NgaySinh = dtpNgaySinh.Value,
                Email = txtEmail.Text,
                SDT = txtSDT.Text,
                DiaChi = txtDiaChi.Text
            };

            nhanVienDAL.ThemNhanVien(nhanVien);
            CapNhatDanhSachNhanVien();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                string maNhanVien = dgvNhanVien.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();
                nhanVienDAL.XoaNhanVien(maNhanVien);
                CapNhatDanhSachNhanVien();
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                string maNhanVien = dgvNhanVien.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();
                NhanVienDTO nhanVienSua = new NhanVienDTO
                {
                    MaNhanVien = maNhanVien,
                    TenNhanVien = txtTenNhanVien.Text,
                    NgaySinh = dtpNgaySinh.Value,
                    Email = txtEmail.Text,
                    SDT = txtSDT.Text,
                    DiaChi = txtDiaChi.Text
                };

                nhanVienDAL.SuaNhanVien(nhanVienSua);
                CapNhatDanhSachNhanVien();
            }
        }

        private void CapNhatDanhSachNhanVien()
        {
            dgvNhanVien.DataSource = nhanVienDAL.DocDanhSachNhanVienTuFile();
        }

    }
}


using System;
using System.Collections.Generic;
using DAL_QuanLyNhanVien;
using DTO_QuanLyNhanVien;

namespace BUS_QuanLyNhanVien
{

    public class BUS_NhanVien
    {
        private DAL_NhanVien dalNhanVien;

        public BUS_NhanVien()
        {
            dalNhanVien = new DAL_NhanVien();
        }

        public void ThemNhanVien(NhanVienDTO nhanVien)
        {
            dalNhanVien.ThemNhanVien(nhanVien);
        }

        public List<NhanVienDTO> LayDanhSachNhanVien()
        {
            return dalNhanVien.LayDanhSachNhanVien();
        }

        public void XoaNhanVien(string maNhanVien)
        {
            dalNhanVien.XoaNhanVien(maNhanVien);
        }

        public void CapNhatThongTinNhanVien(NhanVienDTO nhanVien)
        {
            dalNhanVien.CapNhatThongTinNhanVien(nhanVien);
        }
    }
}
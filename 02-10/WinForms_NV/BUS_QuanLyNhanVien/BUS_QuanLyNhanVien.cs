using System;
using System.Collections.Generic;
using DAL_QuanLyNhanVien;
using DTO_QuanLyNhanVien;

namespace BUS_QuanLyNhanVien
{
    public class BUS_NhanVien
    {
        private DAL_QuanLyNhanVien.DAL_QuanLyNhanVien dalNhanVien;

        public BUS_NhanVien()
        {
            dalNhanVien = new DAL_QuanLyNhanVien.DAL_QuanLyNhanVien();
        }

        public void ThemNhanVien(NhanVien nhanVien)
        {
            dalNhanVien.ThemNhanVien(nhanVien);
        }

        public List<NhanVien> LayDanhSachNhanVien()
        {
            return dalNhanVien.LayDanhSachNhanVien();
        }

        public void XoaNhanVien(string maNhanVien)
        {
            dalNhanVien.XoaNhanVien(maNhanVien);
        }

        public void CapNhatThongTinNhanVien(NhanVien nhanVien)
        {
            dalNhanVien.CapNhatThongTinNhanVien(nhanVien);
        }
    }
}

using DTO_QuanLyNhanVien;
using System;
using System.Collections.Generic;
using System.Linq; // Thêm dòng này để sử dụng LINQ

namespace DAL_QuanLyNhanVien
{
    public class DAL_NhanVien
    {
        private List<NhanVienDTO> danhSachNhanVien = new List<NhanVienDTO>();

        public List<NhanVienDTO> LayDanhSachNhanVien()
        {
            return danhSachNhanVien;
        }

        public void ThemNhanVien(NhanVienDTO nhanVien)
        {
            danhSachNhanVien.Add(nhanVien);
        }

        public void XoaNhanVien(string maNhanVien)
        {
            var nhanVienCanXoa = danhSachNhanVien.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien);

            if (nhanVienCanXoa != null)
            {
                danhSachNhanVien.Remove(nhanVienCanXoa);
            }
        }

        public void CapNhatThongTinNhanVien(NhanVienDTO nhanVien)
        {
            var nhanVienCanSua = danhSachNhanVien.FirstOrDefault(nv => nv.MaNhanVien == nhanVien.MaNhanVien);

            if (nhanVienCanSua != null)
            {
                nhanVienCanSua.TenNhanVien = nhanVien.TenNhanVien;
                nhanVienCanSua.NgaySinh = nhanVien.NgaySinh;
                nhanVienCanSua.Email = nhanVien.Email;
                nhanVienCanSua.SDT = nhanVien.SDT;
                nhanVienCanSua.DiaChi = nhanVien.DiaChi;
            }
        }
    }
}
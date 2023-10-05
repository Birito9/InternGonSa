using DTO_QuanLyNhanVien;
using System;
using System.Collections.Generic;

namespace DAL_QuanLyNhanVien
{
    public class DAL_QuanLyNhanVien
    {
        private List<NhanVien> danhSachNhanVien;

        public DAL_QuanLyNhanVien()
        {
            danhSachNhanVien = new List<NhanVien>();
            // Thêm dữ liệu ảo
            danhSachNhanVien.Add(new NhanVien
            {
                MaNhanVien = "NV001",
                TenNhanVien = "Nguyen Van A",
                NgaySinh = new DateTime(1990, 10, 16),
                Email = "a@gmail.com",
                SDT = "0938929526",
                DiaChi = "123 Main St"
            });
            danhSachNhanVien.Add(new NhanVien
            {
                MaNhanVien = "NV002",
                TenNhanVien = "Tran Thi B",
                NgaySinh = new DateTime(1999, 5, 23),
                Email = "b@gmail.com",
                SDT = "0782444333",
                DiaChi = "456 Elm St"
            });
        }

        public List<NhanVien> LayDanhSachNhanVien()
        {
            return danhSachNhanVien;
        }

        public void ThemNhanVien(NhanVien nhanVien)
        {
            danhSachNhanVien.Add(nhanVien);
        }

        public void XoaNhanVien(string maNhanVien)
        {
            // Tìm và xóa Nhân viên từ danh sách dữ liệu
            var nhanVienCanXoa = danhSachNhanVien.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien);

            if (nhanVienCanXoa != null)
            {
                danhSachNhanVien.Remove(nhanVienCanXoa);
            }
        }

        public void CapNhatThongTinNhanVien(NhanVien nhanVien)
        {
            // Tìm Nhân viên cần sửa trong danh sách dữ liệu (hoặc cơ sở dữ liệu)
            var nhanVienCanSua = danhSachNhanVien.FirstOrDefault(nv => nv.MaNhanVien == nhanVien.MaNhanVien);

            if (nhanVienCanSua != null)
            {
                // Cập nhật thông tin của Nhân viên với thông tin mới từ đối tượng nhanVien
                nhanVienCanSua.TenNhanVien = nhanVien.TenNhanVien;
                nhanVienCanSua.NgaySinh = nhanVien.NgaySinh;
                nhanVienCanSua.Email = nhanVien.Email;
                nhanVienCanSua.SDT = nhanVien.SDT;
                nhanVienCanSua.DiaChi = nhanVien.DiaChi;
            }
        }
    }
}


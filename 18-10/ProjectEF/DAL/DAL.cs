using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
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

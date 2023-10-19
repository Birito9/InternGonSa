using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        private NhanVienDAL nhanVienDAL;

        public NhanVienBLL()
        {
            nhanVienDAL = new NhanVienDAL();
        }

        public void ThemNhanVien(NhanVienDTO nhanVien)
        {
            nhanVienDAL.ThemNhanVien(nhanVien);
        }

        public List<NhanVienDTO> LayDanhSachNhanVien()
        {
            return nhanVienDAL.LayDanhSachNhanVien();
        }

        public void XoaNhanVien(string maNhanVien)
        {
            nhanVienDAL.XoaNhanVien(maNhanVien);
        }

        public void CapNhatThongTinNhanVien(NhanVienDTO nhanVien)
        {
            nhanVienDAL.CapNhatThongTinNhanVien(nhanVien);
        }
    }
}

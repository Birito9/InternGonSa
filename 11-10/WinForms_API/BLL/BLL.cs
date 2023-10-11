using DAL;
using DTO;

namespace BLL
{
    public class NhanVienBLL
    {
        private NhanVienDAL nhanVienDAL = new NhanVienDAL();

        public List<NhanVienDTO> GetAllNhanVien()
        {
            return nhanVienDAL.GetAllNhanVien();
        }

        public NhanVienDTO GetNhanVienByMaNhanVien(string maNhanVien)
        {
            return nhanVienDAL.GetNhanVienByMaNhanVien(maNhanVien);
        }

        public void AddNhanVien(NhanVienDTO nhanVien)
        {
            nhanVienDAL.AddNhanVien(nhanVien);
        }

        public void UpdateNhanVien(NhanVienDTO nhanVien)
        {
            nhanVienDAL.UpdateNhanVien(nhanVien);
        }

        public void DeleteNhanVien(string maNhanVien)
        {
            nhanVienDAL.DeleteNhanVien(maNhanVien);
        }
    }
}
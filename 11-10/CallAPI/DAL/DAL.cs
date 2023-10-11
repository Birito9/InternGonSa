using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Newtonsoft.Json;

namespace DAL
{
    public class NhanVienDAL
    {
        private const string JsonFilePath = "D:/Intern/GitHub/repo/InternGonSa/11-10/GetAPI/ListNhanVien.json";

        public List<NhanVienDTO> DocDanhSachNhanVienTuFile()
        {
            List<NhanVienDTO> danhSachNhanVien = new List<NhanVienDTO>();

            if (File.Exists(JsonFilePath))
            {
                string json = File.ReadAllText(JsonFilePath);
                danhSachNhanVien = JsonConvert.DeserializeObject<List<NhanVienDTO>>(json);
            }

            return danhSachNhanVien;
        }

        public void GhiDanhSachNhanVienVaoFile(List<NhanVienDTO> danhSachNhanVien)
        {
            string json = JsonConvert.SerializeObject(danhSachNhanVien);
            File.WriteAllText(JsonFilePath, json);
        }

        public void ThemNhanVien(NhanVienDTO nhanVien)
        {
            List<NhanVienDTO> danhSachNhanVien = DocDanhSachNhanVienTuFile();
            danhSachNhanVien.Add(nhanVien);
            GhiDanhSachNhanVienVaoFile(danhSachNhanVien);
        }

        public void SuaNhanVien(NhanVienDTO nhanVienSua)
        {
            List<NhanVienDTO> danhSachNhanVien = DocDanhSachNhanVienTuFile();
            int index = danhSachNhanVien.FindIndex(nv => nv.MaNhanVien == nhanVienSua.MaNhanVien);

            if (index >= 0)
            {
                danhSachNhanVien[index] = nhanVienSua;
                GhiDanhSachNhanVienVaoFile(danhSachNhanVien);
            }
        }

        public void XoaNhanVien(string maNhanVien)
        {
            List<NhanVienDTO> danhSachNhanVien = DocDanhSachNhanVienTuFile();
            danhSachNhanVien.RemoveAll(nv => nv.MaNhanVien == maNhanVien);
            GhiDanhSachNhanVienVaoFile(danhSachNhanVien);
        }
    }
}


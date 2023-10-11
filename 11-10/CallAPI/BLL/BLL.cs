using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using DTO;

namespace BLL
{
    public class NhanVienBLL
    {
        private List<NhanVienDTO> danhSachNhanVien;
        private const string JsonFilePath = "D:/Intern/GitHub/repo/InternGonSa/11-10/GetAPI/ListNhanVien.json";

        public NhanVienBLL()
        {
            danhSachNhanVien = LoadNhanVienFromJson();
        }

        private List<NhanVienDTO> LoadNhanVienFromJson()
        {
            if (File.Exists(JsonFilePath))
            {
                string json = File.ReadAllText(JsonFilePath);
                return JsonConvert.DeserializeObject<List<NhanVienDTO>>(json);
            }
            return new List<NhanVienDTO>();
        }

        private void SaveNhanVienToJson()
        {
            string json = JsonConvert.SerializeObject(danhSachNhanVien);
            File.WriteAllText(JsonFilePath, json);
        }

        public void ThemNhanVien(NhanVienDTO nhanVien)
        {
            danhSachNhanVien.Add(nhanVien);
            SaveNhanVienToJson();
        }

        public void XoaNhanVien(string maNhanVien)
        {
            var nhanVienCanXoa = danhSachNhanVien.Find(nv => nv.MaNhanVien == maNhanVien);
            if (nhanVienCanXoa != null)
            {
                danhSachNhanVien.Remove(nhanVienCanXoa);
                SaveNhanVienToJson();
            }
        }

        public void CapNhatNhanVien(NhanVienDTO nhanVien)
        {
            var nhanVienCanCapNhat = danhSachNhanVien.Find(nv => nv.MaNhanVien == nhanVien.MaNhanVien);
            if (nhanVienCanCapNhat != null)
            {
                nhanVienCanCapNhat.TenNhanVien = nhanVien.TenNhanVien;
                nhanVienCanCapNhat.NgaySinh = nhanVien.NgaySinh;
                nhanVienCanCapNhat.Email = nhanVien.Email;
                nhanVienCanCapNhat.SDT = nhanVien.SDT;
                nhanVienCanCapNhat.DiaChi = nhanVien.DiaChi;
                SaveNhanVienToJson();
            }
        }

        public List<NhanVienDTO> LayDanhSachNhanVien()
        {
            return danhSachNhanVien;
        }
    }
}

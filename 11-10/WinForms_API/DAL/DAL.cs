using DTO;
using System.Xml;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DAL
{
    public class NhanVienDAL
    {
        private string filePath = @"D:\Intern\GitHub\repo\InternGonSa\11-10\WinForms_API\ListNhanVien.json";

        public List<NhanVienDTO> GetAllNhanVien()
        {
            List<NhanVienDTO> nhanViens = new List<NhanVienDTO>();
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                nhanViens = JsonConvert.DeserializeObject<List<NhanVienDTO>>(json);
            }
            return nhanViens;
        }

        public NhanVienDTO GetNhanVienByMaNhanVien(string maNhanVien)
        {
            List<NhanVienDTO> nhanViens = GetAllNhanVien();
            return nhanViens.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien);
        }

        public void AddNhanVien(NhanVienDTO nhanVien)
        {
            List<NhanVienDTO> nhanViens = GetAllNhanVien();
            nhanViens.Add(nhanVien);
            SaveNhanViens(nhanViens);
        }

        public void UpdateNhanVien(NhanVienDTO nhanVien)
        {
            List<NhanVienDTO> nhanViens = GetAllNhanVien();
            var existingNhanVien = nhanViens.FirstOrDefault(nv => nv.MaNhanVien == nhanVien.MaNhanVien);
            if (existingNhanVien != null)
            {
                nhanViens[nhanViens.IndexOf(existingNhanVien)] = nhanVien;
                SaveNhanViens(nhanViens);
            }
        }

        public void DeleteNhanVien(string maNhanVien)
        {
            List<NhanVienDTO> nhanViens = GetAllNhanVien();
            var nhanVienToDelete = nhanViens.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien);
            if (nhanVienToDelete != null)
            {
                nhanViens.Remove(nhanVienToDelete);
                SaveNhanViens(nhanViens);
            }
        }

        private void SaveNhanViens(List<NhanVienDTO> nhanViens)
        {
            string json = JsonConvert.SerializeObject(nhanViens, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
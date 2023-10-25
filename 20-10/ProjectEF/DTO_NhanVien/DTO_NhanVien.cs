using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_NhanVien
{
    public class NhanVienDTO
    {
        [Key]
        public string? MaNhanVien { get; set; }
        public string? TenNhanVien { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? Email { get; set; }
        public string? SDT { get; set; }
        public string? DiaChi { get; set; }
        public string? ChucVu { get; set; }
    }
}

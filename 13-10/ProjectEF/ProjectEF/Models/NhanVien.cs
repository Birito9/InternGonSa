namespace ProjectEF.Models
{
    public class NhanVien
    {
        public string? MaNhanVien { get; set; }     // Employee ID
        public string? TenNhanVien { get; set; }    // Employee Name
        public DateTime? NgaySinh { get; set; }     // Date of Birth
        public string? Email { get; set; }          // Employee Email
        public string? SDT { get; set; }            // Employee Phone Number
        public string? DiaChi { get; set; }       // Employee Address
        public string? ChucVu { get; set; }         // Employee Position
    }
}

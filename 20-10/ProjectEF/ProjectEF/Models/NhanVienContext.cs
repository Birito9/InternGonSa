using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class NhanVienContext : DbContext
    {
        public NhanVienContext()
        {
        }

        public NhanVienContext(DbContextOptions<NhanVienContext> options) : base(options)
        {

        }
        public DbSet<NhanVien> NhanViens { get; set;}
    }
}

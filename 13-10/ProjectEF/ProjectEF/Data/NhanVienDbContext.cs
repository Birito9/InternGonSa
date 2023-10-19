using Microsoft.EntityFrameworkCore;
using ProjectEF.Models;

namespace ProjectEF.Data
{
    // Create a DbContext for working with employee data
    public class EmployeeDbContext : DbContext
    {
        public DbSet<NhanVien> NhanViens { get; set; }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define the database table for the NhanVien class
            modelBuilder.Entity<NhanVien>().ToTable("NhanViens");
        }
    }
}

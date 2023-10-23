using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace ProjectEF
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<NhanVienContext>(options => options.UseSqlServer(Configuration.GetConnectionString("NhanVienCS")));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            // Cấu hình middleware ở đây
        }
    }
}

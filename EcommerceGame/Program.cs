using Demo.DAL.Contexts;
using EcommerceGame.BLL.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EcommerceGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services
    .AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<FinalMVCContext>()
    .AddDefaultUI()
    .AddDefaultTokenProviders();
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<FinalMVCContext>(options=> options
            .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            // builder.Services.AddScoped<IdepartmentRepository, departmentRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
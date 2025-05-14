// Author: Antonio Gonzalez
// Course: COMP003B
// Instructor: Jonathan Cruz
// Purpose: Final project synthesizing MVC, Web API, EF Core, and middleware

using COMP003B.SP25.FinalProject.GonzalezA.Data;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.SP25.FinalProject.GonzalezA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			// Database Context
			builder.Services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

			var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

			app.UseMiddleware<COMP003B.SP25.FinalProject.GonzalezA.Middleware.RequestTimingMiddleware>();


			app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}

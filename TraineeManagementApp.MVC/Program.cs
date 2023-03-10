using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TraineeManagementApp.DAL.Repository;
using TraineeManagementApp.DAL.Seeds;
using TraineeManagementApp.DAL.Entities;

namespace TraineeManagementApp.MVC
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<TraineeManagementAppDbContext>(options =>
            {
                //var connectString = builder.Configuration.GetConnectionString("TraineeMgtDbConnection");
                var connectionString = builder.Configuration.GetSection("ConnectionStrings")["DefaultConnection"];
                options.UseSqlServer(connectionString);
            });


            builder.Services.AddScoped<IUnitOfWork, UnitOfWork<TraineeManagementAppDbContext>>();
            /*builder.Services.AddScoped<IAdminService, AdminService>();
            builder.Services.AddScoped<IInstructorService, InstructorService>();
            builder.Services.AddScoped<ITraineeService, TraineeService>();
            builder.Services.AddScoped<ICourseService, CourseService>();
            builder.Services.AddScoped<IEnrollmentService, EnrollmentService>();*/


            builder.Services.AddAutoMapper(Assembly.Load("TraineeManagementApp.BLL"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            await SeedData.EnsurePopulatedAsync(app);

            await app.RunAsync();
        }
    }
}
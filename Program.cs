using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TraineeManagementSystem.BLL.Implementation;
using TraineeManagementSystem.BLL.Interfaces;
using TraineeManagementSystem.DAL.Entities;
using TraineeManagementSystem.DAL.Repository;

namespace TraineeManagementSystem
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<TraineeDbContext>(options =>
            {
                //var connectString = builder.Configuration.GetConnectionString("TraineeMgtDbConnection");
                var connectionString = builder.Configuration.GetSection("ConnectionString")["DefaultConnection"];
                options.UseSqlServer(connectionString);
            });

            //builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<TraineeDbContext>().AddDefaultTokenProviders();
            
            
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork<TraineeDbContext>>();


            builder.Services.AddScoped<IInstructorService, InstructorService>();


            builder.Services.AddScoped<ITraineeService, TraineeService>();
            builder.Services.AddScoped<ICourseService, CourseService>();
            builder.Services.AddScoped<ICareerPathService, CareerPathService>();


            builder.Services.AddAutoMapper(Assembly.Load("TraineeManagementSystem.BLL"));

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

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            //await SeedData.EnsurePopulatedAsync(app);

            await app.RunAsync();
        }
    }
}

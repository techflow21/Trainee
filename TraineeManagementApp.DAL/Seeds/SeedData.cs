using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using TraineeManagementApp.DAL.Entities;
using TraineeManagementApp.DAL.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace TraineeManagementApp.DAL.Seeds;

public class SeedData
{
    public static async Task EnsurePopulatedAsync(IApplicationBuilder app)
    {
        var context = app.ApplicationServices.CreateScope().ServiceProvider
            .GetRequiredService<TraineeManagementAppDbContext>();

        if (!await context.Admins.AnyAsync())
        {
            await context.Admins.AddRangeAsync(DefaultAdmins());
            await context.SaveChangesAsync();
        }

        if (!await context.Instructors.AnyAsync())
        {
            await context.Instructors.AddRangeAsync(DefaultInstructors());
            await context.SaveChangesAsync();
        }

        if (!await context.Trainees.AnyAsync())
        {
            await context.Trainees.AddRangeAsync(DefaultTrainees());
            await context.SaveChangesAsync();
        }

        if (!await context.Courses.AnyAsync())
        {
            await context.Courses.AddRangeAsync(DefaultCourses());
            await context.SaveChangesAsync();
        }

        if (!await context.Enrollments.AnyAsync())
        {
            await context.Enrollments.AddRangeAsync(DefaultEnrollments());
            await context.SaveChangesAsync();
        }
    }


    private static IEnumerable<Admin> DefaultAdmins()
    {
        return new List<Admin>()
        {
            new Admin()
            {
                UserName = "admin",
                Password = "admin123"
            },
            new Admin()
            {
                UserName = "admin2",
                Password = "admin123"
            }
        };
    }


    private static IEnumerable<Instructor> DefaultInstructors()
    {
        return new List<Instructor>()
        {
            new Instructor()
            {
                FirstName = "Adewale",
                LastName = "Johnson",
                PhoneNumber = "08111111111",
                Email = "johnson@mail.com",
                Password = "3333"
            },
            new Instructor()
            {
                FirstName = "David",
                LastName = "Smith",
                PhoneNumber = "08111111444",
                Email = "david@mail.com",
                Password = "3333"
            }
        };
    }


    private static IEnumerable<Trainee> DefaultTrainees()
    {
        return new List<Trainee>()
        {
            new Trainee()
            {
                FirstName = "Chinedu",
                LastName = "Chinenye",
                Email= "chinenye@mail.com",
                PhoneNumber = "084444444444",
                Address = "Enugu, USA",
                Password = "4444"
            },
            new Trainee()
            {
                FirstName = "Ben",
                LastName = "Stanley",
                Email= "ben@mail.com",
                PhoneNumber = "08112233445",
                Address = "Imo, Nigeria",
                Password = "5555"
            }
        };
    }


    private static IEnumerable<Course> DefaultCourses()
    {
        return new List<Course>()
        {
            new Course()
            {
                Title = "Understanding C#",
                Description = "Deep understanding of C# Programming"
            },
            new Course()
            {
                Title = "LINQ 102",
                Description = "The objective of the this course is to clear every doubts about LINQ usage in real world app."
            }
        };
    }


    private static IEnumerable<Enrollment> DefaultEnrollments()
    {
        return new List<Enrollment>()
        {
            new Enrollment()
            {
                Grade = Grade.A,
                Score = 98
            },
            new Enrollment()
            {
                Grade = Grade.B,
                Score = 65
            }
        };
    }
}

/*using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TraineeManagementSystem.DAL.Entities;

namespace TraineeManagementSystem.DAL.Seeds
{
    public class SeedData
    {
        public static async Task EnsurePopulatedAsync(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider
                .GetRequiredService<TraineeDbContext>();

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

            *//*if (!await context.Enrollments.AnyAsync())
            {
                await context.Enrollments.AddRangeAsync(DefaultEnrollments());
                await context.SaveChangesAsync();
            }*//*
        }

        *//*
                private static IEnumerable<Instructor> DefaultAdmins()
                {
                    return new List<Instructor>()
                    {
                        new Instructor()
                        {
                            UserName = "admin",
                            Password = "admin123"
                        },
                        new Instructor()
                        {
                            UserName = "admin2",
                            Password = "admin123"
                        }
                    };
                }*//*


        private static IEnumerable<Instructor> DefaultInstructors()
        {
            return new List<Instructor>()
            {
                new Instructor()
                {
                    FirstName = "Adewale",
                    LastName = "Johnson",
                    PhoneNumber = "08111111111",
                    Email = "johnson@mail.com"
                },
                new Instructor()
                {
                    FirstName = "David",
                    LastName = "Smith",
                    PhoneNumber = "08111111444",
                    Email = "david@mail.com"
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
                    Address = "Enugu, USA"
                },
                new Trainee()
                {
                    FirstName = "Ben",
                    LastName = "Stanley",
                    Email= "ben@mail.com",
                    PhoneNumber = "08112233445",
                    Address = "Imo, Nigeria"
                }
            };
        }

        private static IEnumerable<Course> DefaultCourses()
        {
            return new List<Course>()
            {
                new Course()
                {
                    Title = "Understanding C#"
                },
                new Course()
                {
                    Title = "LINQ 102"
                }
            };
        }


        *//*private static IEnumerable<Enrollment> DefaultEnrollments()
          {
            return new List<Enrollment>()
            {
                new Enrollment()
                {
                    N = "LINQ 102",
                    Grade = Grade.A,
                    Score = 98
                },
                new Enrollment()
                {
                    Name = "Understanding C#",
                    Grade = Grade.B,
                    Score = 65
                }
            };
        }*//*
    }
}
*/
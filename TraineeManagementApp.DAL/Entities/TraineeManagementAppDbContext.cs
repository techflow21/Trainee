using Microsoft.EntityFrameworkCore;

namespace TraineeManagementApp.DAL.Entities
{
    public class TraineeManagementAppDbContext : DbContext
    {
        public TraineeManagementAppDbContext(DbContextOptions<TraineeManagementAppDbContext> options) : base(options)
        {
        }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Trainee> Trainees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Admin>(a =>
            {
                a.Property(a => a.UserName)
                    .IsRequired()
                    .HasMaxLength(30);
                a.HasIndex(a => a.UserName, $"IX_{nameof(Admin)}_{nameof(Admin.UserName)}")
                .IsUnique();

                a.Property(a => a.Password)
                    .IsRequired();
            });

            modelBuilder.Entity<Instructor>(i =>
            {
                i.Property(i => i.FirstName)
                    .IsRequired()
                    .HasMaxLength(20);

                i.Property(i => i.LastName)
                    .IsRequired()
                    .HasMaxLength(20);

                i.Property(i => i.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                i.HasIndex(i => i.Email, $"IX_{nameof(Instructor)}_{nameof(Instructor.Email)}")
                    .IsUnique();

                i.HasIndex(i => i.PhoneNumber, $"IX_{nameof(Instructor)}_{nameof(Instructor.PhoneNumber)}")
                    .IsUnique();
            });

            modelBuilder.Entity<Trainee>(t =>
            {
                t.Property(t => t.FirstName)
                    .IsRequired()
                    .HasMaxLength(20);

                t.Property(t => t.LastName)
                    .IsRequired()
                    .HasMaxLength(20);

                t.Property(t => t.Address)
                    .HasMaxLength(50);

                t.Property(t => t.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                t.HasIndex(t => t.Email, $"IX_{nameof(Trainee)}_{nameof(Trainee.Email)}")
                    .IsUnique();

                t.HasIndex(t => t.PhoneNumber, $"IX_{nameof(Instructor)}_{nameof(Instructor.PhoneNumber)}")
                    .IsUnique();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}

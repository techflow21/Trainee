﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TraineeManagementApp.DAL.Entities;

#nullable disable

namespace TraineeManagementApp.DAL.Migrations
{
    [DbContext(typeof(TraineeManagementAppDbContext))]
    [Migration("20230310070850_UpdatedInstructor")]
    partial class UpdatedInstructor
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TraineeManagementApp.DAL.Entities.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EnrolledDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "UserName" }, "IX_Admin_UserName")
                        .IsUnique();

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("TraineeManagementApp.DAL.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("TraineeManagementApp.DAL.Entities.Enrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EnrolledDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Score")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TraineeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.HasIndex("TraineeId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("TraineeManagementApp.DAL.Entities.Instructor", b =>
                {
                    b.Property<int>("InstructorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InstructorId"));

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateEnrolled")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("InstructorId");

                    b.HasIndex("AdminId");

                    b.HasIndex(new[] { "Email" }, "IX_Instructor_Email")
                        .IsUnique();

                    b.HasIndex(new[] { "PhoneNumber" }, "IX_Instructor_PhoneNumber")
                        .IsUnique();

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("TraineeManagementApp.DAL.Entities.Trainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("EnrolledDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("InstructorId");

                    b.HasIndex(new[] { "PhoneNumber" }, "IX_Instructor_PhoneNumber")
                        .IsUnique();

                    b.HasIndex(new[] { "Email" }, "IX_Trainee_Email")
                        .IsUnique();

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("TraineeManagementApp.DAL.Entities.Course", b =>
                {
                    b.HasOne("TraineeManagementApp.DAL.Entities.Instructor", "Instructor")
                        .WithMany("Courses")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("TraineeManagementApp.DAL.Entities.Enrollment", b =>
                {
                    b.HasOne("TraineeManagementApp.DAL.Entities.Admin", null)
                        .WithMany("Enrollments")
                        .HasForeignKey("AdminId");

                    b.HasOne("TraineeManagementApp.DAL.Entities.Course", null)
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId");

                    b.HasOne("TraineeManagementApp.DAL.Entities.Instructor", null)
                        .WithMany("Enrollments")
                        .HasForeignKey("InstructorId");

                    b.HasOne("TraineeManagementApp.DAL.Entities.Trainee", null)
                        .WithMany("Enrollments")
                        .HasForeignKey("TraineeId");
                });

            modelBuilder.Entity("TraineeManagementApp.DAL.Entities.Instructor", b =>
                {
                    b.HasOne("TraineeManagementApp.DAL.Entities.Admin", null)
                        .WithMany("Instructors")
                        .HasForeignKey("AdminId");
                });

            modelBuilder.Entity("TraineeManagementApp.DAL.Entities.Trainee", b =>
                {
                    b.HasOne("TraineeManagementApp.DAL.Entities.Admin", null)
                        .WithMany("Trainees")
                        .HasForeignKey("AdminId");

                    b.HasOne("TraineeManagementApp.DAL.Entities.Instructor", null)
                        .WithMany("Trainees")
                        .HasForeignKey("InstructorId");
                });

            modelBuilder.Entity("TraineeManagementApp.DAL.Entities.Admin", b =>
                {
                    b.Navigation("Enrollments");

                    b.Navigation("Instructors");

                    b.Navigation("Trainees");
                });

            modelBuilder.Entity("TraineeManagementApp.DAL.Entities.Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("TraineeManagementApp.DAL.Entities.Instructor", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Enrollments");

                    b.Navigation("Trainees");
                });

            modelBuilder.Entity("TraineeManagementApp.DAL.Entities.Trainee", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}

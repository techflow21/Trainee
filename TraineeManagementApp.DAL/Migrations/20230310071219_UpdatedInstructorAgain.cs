using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraineeManagementApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedInstructorAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateEnrolled",
                table: "Instructors",
                newName: "EnrolledDate");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "Instructors",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EnrolledDate",
                table: "Instructors",
                newName: "DateEnrolled");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Instructors",
                newName: "InstructorId");
        }
    }
}

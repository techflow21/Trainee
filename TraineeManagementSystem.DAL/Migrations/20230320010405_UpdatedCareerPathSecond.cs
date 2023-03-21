using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraineeManagementSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCareerPathSecond : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CareerPaths_Instructors_InstructorId",
                table: "CareerPaths");

            migrationBuilder.DropIndex(
                name: "IX_CareerPaths_InstructorId",
                table: "CareerPaths");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "CareerPaths");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CareerPaths",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "CareerPaths");

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "CareerPaths",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CareerPaths_InstructorId",
                table: "CareerPaths",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_CareerPaths_Instructors_InstructorId",
                table: "CareerPaths",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id");
        }
    }
}

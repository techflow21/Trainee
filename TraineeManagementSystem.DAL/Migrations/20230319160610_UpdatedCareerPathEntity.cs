using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraineeManagementSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCareerPathEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CareerPaths_Instructors_InstructorId",
                table: "CareerPaths");

            migrationBuilder.AlterColumn<int>(
                name: "InstructorId",
                table: "CareerPaths",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CareerPaths_Instructors_InstructorId",
                table: "CareerPaths",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CareerPaths_Instructors_InstructorId",
                table: "CareerPaths");

            migrationBuilder.AlterColumn<int>(
                name: "InstructorId",
                table: "CareerPaths",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CareerPaths_Instructors_InstructorId",
                table: "CareerPaths",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

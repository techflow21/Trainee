using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraineeManagementSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedInstructor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Instructor_PhoneNumber",
                table: "Instructors");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Instructors",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_PhoneNumber",
                table: "Instructors",
                column: "PhoneNumber",
                unique: true,
                filter: "[PhoneNumber] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Instructor_PhoneNumber",
                table: "Instructors");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Instructors",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_PhoneNumber",
                table: "Instructors",
                column: "PhoneNumber",
                unique: true);
        }
    }
}

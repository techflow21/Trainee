using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraineeManagementSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedInstructorAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InstructordId",
                table: "CareerPaths");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstructordId",
                table: "CareerPaths",
                type: "int",
                nullable: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyDevelopersApp.API.Migrations
{
    public partial class ExtendedUser2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "HourlySalaryRequirements",
                table: "Users",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HourlySalaryRequirements",
                table: "Users");
        }
    }
}

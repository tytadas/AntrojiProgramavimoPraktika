using Microsoft.EntityFrameworkCore.Migrations;

namespace AnotherProject.Data.Migrations
{
    public partial class UserPhoneNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserPhoneNumber",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserPhoneNumber",
                table: "AspNetUsers");
        }
    }
}

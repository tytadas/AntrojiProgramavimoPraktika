using Microsoft.EntityFrameworkCore.Migrations;

namespace AnotherProject.Data.Migrations
{
    public partial class addApplicationUserIdToComponentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Component",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Component_ApplicationUserId",
                table: "Component",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Component_AspNetUsers_ApplicationUserId",
                table: "Component",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Component_AspNetUsers_ApplicationUserId",
                table: "Component");

            migrationBuilder.DropIndex(
                name: "IX_Component_ApplicationUserId",
                table: "Component");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Component");
        }
    }
}

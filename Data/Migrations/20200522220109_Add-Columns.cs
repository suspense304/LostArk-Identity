using Microsoft.EntityFrameworkCore.Migrations;

namespace LostArk_Identity.Data.Migrations
{
    public partial class AddColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CharClass",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "ItemLevel",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CharClass",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ItemLevel",
                table: "AspNetUsers");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace LostArk_Identity.Data.Migrations
{
    public partial class DiscordName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DiscordName",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscordName",
                table: "AspNetUsers");
        }
    }
}

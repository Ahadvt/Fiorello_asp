using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class addedtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ParallaxTitle",
                table: "Settings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Parallaximg",
                table: "Settings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParallaxTitle",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "Parallaximg",
                table: "Settings");
        }
    }
}

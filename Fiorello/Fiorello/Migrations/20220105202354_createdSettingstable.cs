using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class createdSettingstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(nullable: true),
                    SearchIcon = table.Column<string>(nullable: true),
                    BasketIcon = table.Column<string>(nullable: true),
                    FlowerExTitle = table.Column<string>(nullable: true),
                    FlowerExDesc = table.Column<string>(nullable: true),
                    BlogDesc = table.Column<string>(nullable: true),
                    BlogTitle = table.Column<string>(nullable: true),
                    InstagramUrl = table.Column<string>(nullable: true),
                    FacebookUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");
        }
    }
}

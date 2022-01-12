using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class createdexpertandposition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpertPositions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Expertts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Img = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ExpertPositionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expertts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expertts_ExpertPositions_ExpertPositionId",
                        column: x => x.ExpertPositionId,
                        principalTable: "ExpertPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expertts_ExpertPositionId",
                table: "Expertts",
                column: "ExpertPositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expertts");

            migrationBuilder.DropTable(
                name: "ExpertPositions");
        }
    }
}

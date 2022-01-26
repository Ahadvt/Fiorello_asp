using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class chanhedbasketitemstringtoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_basketItems_Products_ProductId1",
                table: "basketItems");

            migrationBuilder.DropIndex(
                name: "IX_basketItems_ProductId1",
                table: "basketItems");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "basketItems");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "basketItems",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_basketItems_ProductId",
                table: "basketItems",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_basketItems_Products_ProductId",
                table: "basketItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_basketItems_Products_ProductId",
                table: "basketItems");

            migrationBuilder.DropIndex(
                name: "IX_basketItems_ProductId",
                table: "basketItems");

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "basketItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ProductId1",
                table: "basketItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_basketItems_ProductId1",
                table: "basketItems",
                column: "ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_basketItems_Products_ProductId1",
                table: "basketItems",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

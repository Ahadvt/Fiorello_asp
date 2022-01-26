using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class created2basketitem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItem_AspNetUsers_AppUserId",
                table: "BasketItem");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketItem_Products_ProductId1",
                table: "BasketItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasketItem",
                table: "BasketItem");

            migrationBuilder.RenameTable(
                name: "BasketItem",
                newName: "basketItems");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItem_ProductId1",
                table: "basketItems",
                newName: "IX_basketItems_ProductId1");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItem_AppUserId",
                table: "basketItems",
                newName: "IX_basketItems_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_basketItems",
                table: "basketItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_basketItems_AspNetUsers_AppUserId",
                table: "basketItems",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_basketItems_Products_ProductId1",
                table: "basketItems",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_basketItems_AspNetUsers_AppUserId",
                table: "basketItems");

            migrationBuilder.DropForeignKey(
                name: "FK_basketItems_Products_ProductId1",
                table: "basketItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_basketItems",
                table: "basketItems");

            migrationBuilder.RenameTable(
                name: "basketItems",
                newName: "BasketItem");

            migrationBuilder.RenameIndex(
                name: "IX_basketItems_ProductId1",
                table: "BasketItem",
                newName: "IX_BasketItem_ProductId1");

            migrationBuilder.RenameIndex(
                name: "IX_basketItems_AppUserId",
                table: "BasketItem",
                newName: "IX_BasketItem_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasketItem",
                table: "BasketItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItem_AspNetUsers_AppUserId",
                table: "BasketItem",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItem_Products_ProductId1",
                table: "BasketItem",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

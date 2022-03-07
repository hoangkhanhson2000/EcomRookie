using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rookie.Ecom.DataAccessor.Migrations
{
    public partial class _2ndmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CartItemId",
                table: "Product",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_CartItemId",
                table: "Product",
                column: "CartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_CartItem_CartItemId",
                table: "Product",
                column: "CartItemId",
                principalTable: "CartItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_CartItem_CartItemId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_CartItemId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CartItemId",
                table: "Product");
        }
    }
}

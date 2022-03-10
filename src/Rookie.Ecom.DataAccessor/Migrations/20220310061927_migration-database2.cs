using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rookie.Ecom.DataAccessor.Migrations
{
    public partial class migrationdatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_CategoryId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Product");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "Category",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_ProductId",
                table: "Category",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Product_ProductId",
                table: "Category",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Product_ProductId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_ProductId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Category");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Product",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

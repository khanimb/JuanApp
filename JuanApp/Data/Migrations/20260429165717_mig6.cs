using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JuanApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 4, 29, 20, 57, 17, 210, DateTimeKind.Local).AddTicks(1896), false, "Men Shoes" },
                    { 2, new DateTime(2026, 4, 29, 20, 57, 17, 211, DateTimeKind.Local).AddTicks(1028), false, "Women Shoes" },
                    { 3, new DateTime(2026, 4, 29, 20, 57, 17, 211, DateTimeKind.Local).AddTicks(1041), false, "Kids Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "DiscountPrice", "ImageUrl", "IsDeleted", "IsNew", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2026, 4, 29, 20, 57, 17, 211, DateTimeKind.Local).AddTicks(4541), "Some brief description here", 70.0, "/assets/img/product/product-1.jpg", false, true, "Leather Mens Slipper", 80.0 },
                    { 2, 1, new DateTime(2026, 4, 29, 20, 57, 17, 211, DateTimeKind.Local).AddTicks(4853), "Some brief description here", 70.0, "/assets/img/product/product-2.jpg", false, true, "Quickiin Mens shoes", 80.0 },
                    { 3, 2, new DateTime(2026, 4, 29, 20, 57, 17, 211, DateTimeKind.Local).AddTicks(4855), "Some brief description here", 70.0, "/assets/img/product/product-3.jpg", false, true, "Rexpo Womens shoes", 80.0 },
                    { 4, 1, new DateTime(2026, 4, 29, 20, 57, 17, 211, DateTimeKind.Local).AddTicks(4857), "Some brief description here", 110.0, "/assets/img/product/product-4.jpg", false, true, "Air Force 1", 120.0 },
                    { 5, 1, new DateTime(2026, 4, 29, 20, 57, 17, 211, DateTimeKind.Local).AddTicks(4859), "Some brief description here", 130.0, "/assets/img/product/product-5.jpg", false, true, "Air Max", 150.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

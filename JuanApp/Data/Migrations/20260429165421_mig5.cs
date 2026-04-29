using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JuanApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "BtnText", "Desc", "Image", "Offer", "Title" },
                values: new object[,]
                {
                    { 1, "SHOP NOW", "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid", "assets/img/slider/slider-1.jpg", "Top Selling!", "New Collection" },
                    { 2, "SHOP NOW", "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid", "assets/img/slider/slider-2.jpg", "Best Selling!", "Top Collection" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LuxuryAutos.Migrations
{
    public partial class NewSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CarPicture",
                value: "/Images/f12Optimized.jpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CarPicture",
                value: "/Images/aventadorOptimized.jpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CarPicture",
                value: "/Images/gt3Optomized.jpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CarPicture",
                value: "/Images/vanquish-zagata.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CarPicture",
                value: "~/Images/f12Optimized.jpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CarPicture",
                value: "~/Images/aventadorOptimized.jpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CarPicture",
                value: "~/Images/gt3Optomized.jpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CarPicture",
                value: "~/Images/vanquish-zagata.jpg");
        }
    }
}

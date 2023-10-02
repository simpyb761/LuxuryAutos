using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LuxuryAutos.Migrations
{
    public partial class NewSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CarPicture",
                value: "/Images/gt3Optimized.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CarPicture",
                value: "/Images/gt3Optomized.jpg");
        }
    }
}

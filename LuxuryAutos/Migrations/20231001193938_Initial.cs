using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LuxuryAutos.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Make = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    TopSpeed = table.Column<int>(type: "int", nullable: true),
                    CarPicture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarPicture", "Make", "Model", "Price", "TopSpeed" },
                values: new object[,]
                {
                    { 1, "~/Images/f12Optimized.jpg", 0, "F12", 289999.0, 211 },
                    { 2, "~/Images/aventadorOptimized.jpg", 1, "Aventador", 556000.0, 220 },
                    { 3, "~/Images/gt3Optomized.jpg", 2, "911 GT3 RS", 250000.0, 184 },
                    { 4, "~/Images/vanquish-zagata.jpg", 0, "F12", 289999.0, 211 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}

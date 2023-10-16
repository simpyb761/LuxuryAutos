using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LuxuryAutos.Migrations
{
    public partial class LocationUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manager = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "Address", "LocationName", "Manager" },
                values: new object[,]
                {
                    { 1, "9155 Audubon Rd", "Detroit", "Joonas Qemu'el" },
                    { 2, "5154 Greystone Ct", "Traverse City", "Sophia August" },
                    { 3, "602 3rd Ave", "Grand Rapids", "Milana David" },
                    { 4, "500 Tamarack Ct", "Lansing", "Jason Lawson" }
                });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "LocationId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "LocationId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "LocationId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_LocationId",
                table: "Cars",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Locations_LocationId",
                table: "Cars",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Locations_LocationId",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Cars_LocationId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Cars");
        }
    }
}

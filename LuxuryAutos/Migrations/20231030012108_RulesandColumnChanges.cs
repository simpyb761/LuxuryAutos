using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LuxuryAutos.Migrations
{
    public partial class RulesandColumnChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LocationName",
                table: "Locations",
                newName: "Location Name");

            migrationBuilder.RenameColumn(
                name: "TopSpeed",
                table: "Cars",
                newName: "Top Speed");

            migrationBuilder.RenameColumn(
                name: "CarPicture",
                table: "Cars",
                newName: "Picture Reference");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Location Name",
                table: "Locations",
                newName: "LocationName");

            migrationBuilder.RenameColumn(
                name: "Top Speed",
                table: "Cars",
                newName: "TopSpeed");

            migrationBuilder.RenameColumn(
                name: "Picture Reference",
                table: "Cars",
                newName: "CarPicture");
        }
    }
}

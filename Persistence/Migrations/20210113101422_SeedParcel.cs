using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedParcel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "Number", "DestinationCountry", "Price", "RecepientName", "Weight", "bagNumber" },
                values: new object[] { "ee252525", "Estonia", 12.0, "Vladyslav", 25.199999999999999, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parcels",
                keyColumn: "Number",
                keyValue: "ee252525");
        }
    }
}

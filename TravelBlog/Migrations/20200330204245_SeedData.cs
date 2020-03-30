using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelBlog.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "Location", "Year" },
                values: new object[] { 6, "Oregon", 1859 });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "Location", "Year" },
                values: new object[] { 7, "Washington", 1889 });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "Location", "Year" },
                values: new object[] { 8, "Idaho", 1890 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 8);

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "Location", "Year" },
                values: new object[] { 1, "Oregon", 1859 });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "Location", "Year" },
                values: new object[] { 3, "Washington", 1889 });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "Location", "Year" },
                values: new object[] { 4, "Idaho", 1890 });
        }
    }
}

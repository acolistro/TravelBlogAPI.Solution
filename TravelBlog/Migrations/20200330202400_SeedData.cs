using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelBlog.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "Location", "Year" },
                values: new object[,]
                {
                    { 1, "Oregon", 1859 },
                    { 2, "California", 1850 },
                    { 3, "Washington", 1889 },
                    { 4, "Idaho", 1890 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 4);
        }
    }
}

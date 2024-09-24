using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhiteLagoon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Royal Villa provides beachfront accommodations in Trabzon. This villa offers free private parking and a shared kitchen.", "https://limestays.com/wp-content/uploads/2023/01/34-926x618.jpg", "Royal Villa", 4, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lexis Hibiscus Port Dickson, Port Dickson. No Reservation Costs. Great Rates. Villas. Apartments. 24/7 Customer Service. Hotels. Hostels. Great Availability. Flight + Hotel. Airport Taxi available. Low Rates. Special Offers. Amenities", "https://image-tc.galaxy.tf/wijpeg-zql4sgfuf33lj1orh652feqe/lexis-hibiscus-port-dickson-premium-pool-villa-private-pool-1_wide.jpg?crop=0%2C188%2C2000%2C1125", "Premium Pool Villa", 4, 300.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soneva Kiri comprises 32 expansive one to five-bedroom luxury pool villas in Thailand that blend seamlessly with the island's natural beauty", "https://www.ataman-resort.com/wp-content/uploads/2021/01/1-Villa-Luxury-front-view-night-1170x680.jpg", "Luxury Pool Villa", 4, 400.0, 750, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ContactAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialContacts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Email", "MobileNumber", "Name", "Photo", "SecondaryMobileNumber" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", "1234567890", "John Doe", "", "0987654321" },
                    { 2, "jane.smith@example.com", "2345678901", "Jane Smith", "", "1987654321" },
                    { 3, "michael.johnson@example.com", "3456789012", "Michael Johnson", "", "2987654321" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

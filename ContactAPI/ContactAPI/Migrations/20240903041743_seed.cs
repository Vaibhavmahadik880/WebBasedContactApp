using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ContactAPI.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Photo",
                value: "https://randomuser.me/api/portraits/men/1.jpg");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Photo",
                value: "https://randomuser.me/api/portraits/women/2.jpg");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Photo",
                value: "https://randomuser.me/api/portraits/men/3.jpg");

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Email", "MobileNumber", "Name", "Photo", "SecondaryMobileNumber" },
                values: new object[,]
                {
                    { 4, "emily.davis@example.com", "4567890123", "Emily Davis", "https://randomuser.me/api/portraits/women/4.jpg", "3987654321" },
                    { 5, "david.wilson@example.com", "5678901234", "David Wilson", "https://randomuser.me/api/portraits/men/5.jpg", "4987654321" },
                    { 6, "sophia.brown@example.com", "6789012345", "Sophia Brown", "https://randomuser.me/api/portraits/women/6.jpg", "5987654321" },
                    { 7, "james.anderson@example.com", "7890123456", "James Anderson", "https://randomuser.me/api/portraits/men/7.jpg", "6987654321" },
                    { 8, "olivia.martinez@example.com", "8901234567", "Olivia Martinez", "https://randomuser.me/api/portraits/women/8.jpg", "7987654321" },
                    { 9, "benjamin.garcia@example.com", "9012345678", "Benjamin Garcia", "https://randomuser.me/api/portraits/men/9.jpg", "8987654321" },
                    { 10, "charlotte.miller@example.com", "0123456789", "Charlotte Miller", "https://randomuser.me/api/portraits/women/10.jpg", "9987654321" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Photo",
                value: "");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Photo",
                value: "");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Photo",
                value: "");
        }
    }
}

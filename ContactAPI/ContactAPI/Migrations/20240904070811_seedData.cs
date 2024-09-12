using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 20);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Email", "MobileNumber", "Name", "Photo", "SecondaryMobileNumber" },
                values: new object[] { 20, "ritika.chavan20@example.com", "9091223344", "Ritika Chavan", "https://randomuser.me/api/portraits/women/20.jpg", "9009987666" });
        }
    }
}

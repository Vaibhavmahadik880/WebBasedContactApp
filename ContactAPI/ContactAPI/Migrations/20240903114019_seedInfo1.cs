using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ContactAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedInfo1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Email", "MobileNumber", "Name", "Photo", "SecondaryMobileNumber" },
                values: new object[,]
                {
                    { 11, "rahul.deshmukh11@example.com", "9922334455", "Rahul Deshmukh", "https://randomuser.me/api/portraits/men/11.jpg", "9988776655" },
                    { 12, "sneha.patil12@example.com", "9823445566", "Sneha Patil", "https://randomuser.me/api/portraits/women/12.jpg", "9887665544" },
                    { 13, "siddharth.kulkarni13@example.com", "9734556677", "Siddharth Kulkarni", "https://randomuser.me/api/portraits/men/13.jpg", "9776554433" },
                    { 14, "pooja.jadhav14@example.com", "9645667788", "Pooja Jadhav", "https://randomuser.me/api/portraits/women/14.jpg", "9665443322" },
                    { 15, "akshay.shinde15@example.com", "9556778899", "Akshay Shinde", "https://randomuser.me/api/portraits/men/15.jpg", "9554332211" },
                    { 16, "neha.pawar16@example.com", "9467889900", "Neha Pawar", "https://randomuser.me/api/portraits/women/16.jpg", "9443221100" },
                    { 17, "vishal.gaikwad17@example.com", "9378990011", "Vishal Gaikwad", "https://randomuser.me/api/portraits/men/17.jpg", "9332110099" },
                    { 18, "priya.joshi18@example.com", "9289001122", "Priya Joshi", "https://randomuser.me/api/portraits/women/18.jpg", "9221009988" },
                    { 19, "aditya.pawar19@example.com", "9190112233", "Aditya Pawar", "https://randomuser.me/api/portraits/men/19.jpg", "9110098777" },
                    { 20, "ritika.chavan20@example.com", "9091223344", "Ritika Chavan", "https://randomuser.me/api/portraits/women/20.jpg", "9009987666" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}

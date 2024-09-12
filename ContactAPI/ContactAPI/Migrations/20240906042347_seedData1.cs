using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ContactAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Email", "MobileNumber", "Name", "Photo", "SecondaryMobileNumber" },
                values: new object[,]
                {
                    { 51, "anjali.sharma51@example.com", "919923456001", "Anjali Sharma", "https://randomuser.me/api/portraits/women/51.jpg", "918012345601" },
                    { 52, "vikram.malhotra52@example.com", "919923456002", "Vikram Malhotra", "https://randomuser.me/api/portraits/men/52.jpg", "918012345602" },
                    { 53, "priya.nair53@example.com", "919923456003", "Priya Nair", "https://randomuser.me/api/portraits/women/53.jpg", "918012345603" },
                    { 54, "rohit.mehta54@example.com", "919923456004", "Rohit Mehta", "https://randomuser.me/api/portraits/men/54.jpg", "918012345604" },
                    { 55, "sana.kapoor55@example.com", "919923456005", "Sana Kapoor", "https://randomuser.me/api/portraits/women/55.jpg", "918012345605" },
                    { 56, "rakesh.iyer56@example.com", "919923456006", "Rakesh Iyer", "https://randomuser.me/api/portraits/men/56.jpg", "918012345606" },
                    { 57, "neha.bhatia57@example.com", "919923456007", "Neha Bhatia", "https://randomuser.me/api/portraits/women/57.jpg", "918012345607" },
                    { 58, "aman.verma58@example.com", "919923456008", "Aman Verma", "https://randomuser.me/api/portraits/men/58.jpg", "918012345608" },
                    { 59, "kavita.shetty59@example.com", "919923456009", "Kavita Shetty", "https://randomuser.me/api/portraits/women/59.jpg", "918012345609" },
                    { 60, "nikhil.jain60@example.com", "919923456010", "Nikhil Jain", "https://randomuser.me/api/portraits/men/60.jpg", "918012345610" },
                    { 61, "divya.reddy61@example.com", "919923456011", "Divya Reddy", "https://randomuser.me/api/portraits/women/61.jpg", "918012345611" },
                    { 62, "manish.gupta62@example.com", "919923456012", "Manish Gupta", "https://randomuser.me/api/portraits/men/62.jpg", "918012345612" },
                    { 63, "pooja.rai63@example.com", "919923456013", "Pooja Rai", "https://randomuser.me/api/portraits/women/63.jpg", "918012345613" },
                    { 64, "saurabh.khanna64@example.com", "919923456014", "Saurabh Khanna", "https://randomuser.me/api/portraits/men/64.jpg", "918012345614" },
                    { 65, "ayesha.khan65@example.com", "919923456015", "Ayesha Khan", "https://randomuser.me/api/portraits/women/65.jpg", "918012345615" },
                    { 66, "rahul.sen66@example.com", "919923456016", "Rahul Sen", "https://randomuser.me/api/portraits/men/66.jpg", "918012345616" },
                    { 67, "megha.dixit67@example.com", "919923456017", "Megha Dixit", "https://randomuser.me/api/portraits/women/67.jpg", "918012345617" },
                    { 68, "ashish.pandey68@example.com", "919923456018", "Ashish Pandey", "https://randomuser.me/api/portraits/men/68.jpg", "918012345618" },
                    { 69, "simran.singh69@example.com", "919923456019", "Simran Singh", "https://randomuser.me/api/portraits/women/69.jpg", "918012345619" },
                    { 70, "ajay.kumar70@example.com", "919923456020", "Ajay Kumar", "https://randomuser.me/api/portraits/men/70.jpg", "918012345620" },
                    { 71, "ritika.chauhan71@example.com", "919923456021", "Ritika Chauhan", "https://randomuser.me/api/portraits/women/71.jpg", "918012345621" },
                    { 72, "siddharth.joshi72@example.com", "919923456022", "Siddharth Joshi", "https://randomuser.me/api/portraits/men/72.jpg", "918012345622" },
                    { 73, "kriti.ahuja73@example.com", "919923456023", "Kriti Ahuja", "https://randomuser.me/api/portraits/women/73.jpg", "918012345623" },
                    { 74, "ravi.thakur74@example.com", "919923456024", "Ravi Thakur", "https://randomuser.me/api/portraits/men/74.jpg", "918012345624" },
                    { 75, "sonia.dutta75@example.com", "919923456025", "Sonia Dutta", "https://randomuser.me/api/portraits/women/75.jpg", "918012345625" },
                    { 76, "arjun.bhatt76@example.com", "919923456026", "Arjun Bhatt", "https://randomuser.me/api/portraits/men/76.jpg", "918012345626" },
                    { 77, "riya.roy77@example.com", "919923456027", "Riya Roy", "https://randomuser.me/api/portraits/women/77.jpg", "918012345627" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Email", "MobileNumber", "Name", "Photo", "SecondaryMobileNumber" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", "1234567890", "John Doe", "https://randomuser.me/api/portraits/men/1.jpg", "0987654321" },
                    { 2, "jane.smith@example.com", "2345678901", "Jane Smith", "https://randomuser.me/api/portraits/women/2.jpg", "1987654321" },
                    { 3, "michael.johnson@example.com", "3456789012", "Michael Johnson", "https://randomuser.me/api/portraits/men/3.jpg", "2987654321" },
                    { 4, "emily.davis@example.com", "4567890123", "Emily Davis", "https://randomuser.me/api/portraits/women/4.jpg", "3987654321" },
                    { 5, "david.wilson@example.com", "5678901234", "David Wilson", "https://randomuser.me/api/portraits/men/5.jpg", "4987654321" },
                    { 6, "sophia.brown@example.com", "6789012345", "Sophia Brown", "https://randomuser.me/api/portraits/women/6.jpg", "5987654321" },
                    { 7, "james.anderson@example.com", "7890123456", "James Anderson", "https://randomuser.me/api/portraits/men/7.jpg", "6987654321" },
                    { 8, "olivia.martinez@example.com", "8901234567", "Olivia Martinez", "https://randomuser.me/api/portraits/women/8.jpg", "7987654321" },
                    { 9, "benjamin.garcia@example.com", "9012345678", "Benjamin Garcia", "https://randomuser.me/api/portraits/men/9.jpg", "8987654321" },
                    { 10, "charlotte.miller@example.com", "0123456789", "Charlotte Miller", "https://randomuser.me/api/portraits/women/10.jpg", "9987654321" },
                    { 11, "rahul.deshmukh11@example.com", "9922334455", "Rahul Deshmukh", "https://randomuser.me/api/portraits/men/11.jpg", "9988776655" },
                    { 12, "sneha.patil12@example.com", "9823445566", "Sneha Patil", "https://randomuser.me/api/portraits/women/12.jpg", "9887665544" },
                    { 13, "siddharth.kulkarni13@example.com", "9734556677", "Siddharth Kulkarni", "https://randomuser.me/api/portraits/men/13.jpg", "9776554433" },
                    { 14, "pooja.jadhav14@example.com", "9645667788", "Pooja Jadhav", "https://randomuser.me/api/portraits/women/14.jpg", "9665443322" },
                    { 15, "akshay.shinde15@example.com", "9556778899", "Akshay Shinde", "https://randomuser.me/api/portraits/men/15.jpg", "9554332211" },
                    { 16, "neha.pawar16@example.com", "9467889900", "Neha Pawar", "https://randomuser.me/api/portraits/women/16.jpg", "9443221100" },
                    { 17, "vishal.gaikwad17@example.com", "9378990011", "Vishal Gaikwad", "https://randomuser.me/api/portraits/men/17.jpg", "9332110099" },
                    { 18, "priya.joshi18@example.com", "9289001122", "Priya Joshi", "https://randomuser.me/api/portraits/women/18.jpg", "9221009988" },
                    { 19, "aditya.pawar19@example.com", "9190112233", "Aditya Pawar", "https://randomuser.me/api/portraits/men/19.jpg", "9110098777" }
                });
        }
    }
}

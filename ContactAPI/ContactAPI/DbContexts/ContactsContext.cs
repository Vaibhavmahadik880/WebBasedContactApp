using ContactAPI.Entitties;
using ContactAPI.Entitties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;

namespace ContactAPI.DbContexts
{
    public class ContactsContext : DbContext
    {
        public ContactsContext(DbContextOptions<ContactsContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
             


        new Contact
        {
            Id = 51,
            Name = "Anjali Sharma",
            MobileNumber = "919923456001",
            SecondaryMobileNumber = "918012345601",
            Email = "anjali.sharma51@example.com",
            Photo = "https://randomuser.me/api/portraits/women/51.jpg"
        },
            new Contact
            {
                Id = 52,
                Name = "Vikram Malhotra",
                MobileNumber = "919923456002",
                SecondaryMobileNumber = "918012345602",
                Email = "vikram.malhotra52@example.com",
                Photo = "https://randomuser.me/api/portraits/men/52.jpg"
            },
            new Contact
            {
                Id = 53,
                Name = "Priya Nair",
                MobileNumber = "919923456003",
                SecondaryMobileNumber = "918012345603",
                Email = "priya.nair53@example.com",
                Photo = "https://randomuser.me/api/portraits/women/53.jpg"
            },
            new Contact
            {
                Id = 54,
                Name = "Rohit Mehta",
                MobileNumber = "919923456004",
                SecondaryMobileNumber = "918012345604",
                Email = "rohit.mehta54@example.com",
                Photo = "https://randomuser.me/api/portraits/men/54.jpg"
            },
            new Contact
            {
                Id = 55,
                Name = "Sana Kapoor",
                MobileNumber = "919923456005",
                SecondaryMobileNumber = "918012345605",
                Email = "sana.kapoor55@example.com",
                Photo = "https://randomuser.me/api/portraits/women/55.jpg"
            },
            new Contact
            {
                Id = 56,
                Name = "Rakesh Iyer",
                MobileNumber = "919923456006",
                SecondaryMobileNumber = "918012345606",
                Email = "rakesh.iyer56@example.com",
                Photo = "https://randomuser.me/api/portraits/men/56.jpg"
            },
            new Contact
            {
                Id = 57,
                Name = "Neha Bhatia",
                MobileNumber = "919923456007",
                SecondaryMobileNumber = "918012345607",
                Email = "neha.bhatia57@example.com",
                Photo = "https://randomuser.me/api/portraits/women/57.jpg"
            },
            new Contact
            {
                Id = 58,
                Name = "Aman Verma",
                MobileNumber = "919923456008",
                SecondaryMobileNumber = "918012345608",
                Email = "aman.verma58@example.com",
                Photo = "https://randomuser.me/api/portraits/men/58.jpg"
            },
            new Contact
            {
                Id = 59,
                Name = "Kavita Shetty",
                MobileNumber = "919923456009",
                SecondaryMobileNumber = "918012345609",
                Email = "kavita.shetty59@example.com",
                Photo = "https://randomuser.me/api/portraits/women/59.jpg"
            },
            new Contact
            {
                Id = 60,
                Name = "Nikhil Jain",
                MobileNumber = "919923456010",
                SecondaryMobileNumber = "918012345610",
                Email = "nikhil.jain60@example.com",
                Photo = "https://randomuser.me/api/portraits/men/60.jpg"
            },
            new Contact
            {
                Id = 61,
                Name = "Divya Reddy",
                MobileNumber = "919923456011",
                SecondaryMobileNumber = "918012345611",
                Email = "divya.reddy61@example.com",
                Photo = "https://randomuser.me/api/portraits/women/61.jpg"
            },
            new Contact
            {
                Id = 62,
                Name = "Manish Gupta",
                MobileNumber = "919923456012",
                SecondaryMobileNumber = "918012345612",
                Email = "manish.gupta62@example.com",
                Photo = "https://randomuser.me/api/portraits/men/62.jpg"
            },
            new Contact
            {
                Id = 63,
                Name = "Pooja Rai",
                MobileNumber = "919923456013",
                SecondaryMobileNumber = "918012345613",
                Email = "pooja.rai63@example.com",
                Photo = "https://randomuser.me/api/portraits/women/63.jpg"
            },
            new Contact
            {
                Id = 64,
                Name = "Saurabh Khanna",
                MobileNumber = "919923456014",
                SecondaryMobileNumber = "918012345614",
                Email = "saurabh.khanna64@example.com",
                Photo = "https://randomuser.me/api/portraits/men/64.jpg"
            },
            new Contact
            {
                Id = 65,
                Name = "Ayesha Khan",
                MobileNumber = "919923456015",
                SecondaryMobileNumber = "918012345615",
                Email = "ayesha.khan65@example.com",
                Photo = "https://randomuser.me/api/portraits/women/65.jpg"
            },
            new Contact
            {
                Id = 66,
                Name = "Rahul Sen",
                MobileNumber = "919923456016",
                SecondaryMobileNumber = "918012345616",
                Email = "rahul.sen66@example.com",
                Photo = "https://randomuser.me/api/portraits/men/66.jpg"
            },
            new Contact
            {
                Id = 67,
                Name = "Megha Dixit",
                MobileNumber = "919923456017",
                SecondaryMobileNumber = "918012345617",
                Email = "megha.dixit67@example.com",
                Photo = "https://randomuser.me/api/portraits/women/67.jpg"
            },
            new Contact
            {
                Id = 68,
                Name = "Ashish Pandey",
                MobileNumber = "919923456018",
                SecondaryMobileNumber = "918012345618",
                Email = "ashish.pandey68@example.com",
                Photo = "https://randomuser.me/api/portraits/men/68.jpg"
            },
            new Contact
            {
                Id = 69,
                Name = "Simran Singh",
                MobileNumber = "919923456019",
                SecondaryMobileNumber = "918012345619",
                Email = "simran.singh69@example.com",
                Photo = "https://randomuser.me/api/portraits/women/69.jpg"
            },
            new Contact
            {
                Id = 70,
                Name = "Ajay Kumar",
                MobileNumber = "919923456020",
                SecondaryMobileNumber = "918012345620",
                Email = "ajay.kumar70@example.com",
                Photo = "https://randomuser.me/api/portraits/men/70.jpg"
            },
            new Contact
            {
                Id = 71,
                Name = "Ritika Chauhan",
                MobileNumber = "919923456021",
                SecondaryMobileNumber = "918012345621",
                Email = "ritika.chauhan71@example.com",
                Photo = "https://randomuser.me/api/portraits/women/71.jpg"
            },
            new Contact
            {
                Id = 72,
                Name = "Siddharth Joshi",
                MobileNumber = "919923456022",
                SecondaryMobileNumber = "918012345622",
                Email = "siddharth.joshi72@example.com",
                Photo = "https://randomuser.me/api/portraits/men/72.jpg"
            },
            new Contact
            {
                Id = 73,
                Name = "Kriti Ahuja",
                MobileNumber = "919923456023",
                SecondaryMobileNumber = "918012345623",
                Email = "kriti.ahuja73@example.com",
                Photo = "https://randomuser.me/api/portraits/women/73.jpg"
            },
            new Contact
            {
                Id = 74,
                Name = "Ravi Thakur",
                MobileNumber = "919923456024",
                SecondaryMobileNumber = "918012345624",
                Email = "ravi.thakur74@example.com",
                Photo = "https://randomuser.me/api/portraits/men/74.jpg"
            },
            new Contact
            {
                Id = 75,
                Name = "Sonia Dutta",
                MobileNumber = "919923456025",
                SecondaryMobileNumber = "918012345625",
                Email = "sonia.dutta75@example.com",
                Photo = "https://randomuser.me/api/portraits/women/75.jpg"
            },
            new Contact
            {
                Id = 76,
                Name = "Arjun Bhatt",
                MobileNumber = "919923456026",
                SecondaryMobileNumber = "918012345626",
                Email = "arjun.bhatt76@example.com",
                Photo = "https://randomuser.me/api/portraits/men/76.jpg"
            },
            new Contact
            {
                Id = 77,
                Name = "Riya Roy",
                MobileNumber = "919923456027",
                SecondaryMobileNumber = "918012345627",
                Email = "riya.roy77@example.com",
                Photo = "https://randomuser.me/api/portraits/women/77.jpg"
            }



            );
        }
    }
}

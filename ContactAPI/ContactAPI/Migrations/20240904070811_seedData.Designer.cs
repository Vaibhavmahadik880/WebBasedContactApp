﻿// <auto-generated />
using ContactAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContactAPI.Migrations
{
    [DbContext(typeof(ContactsContext))]
    [Migration("20240904070811_seedData")]
    partial class seedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("ContactAPI.Entitties.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SecondaryMobileNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "john.doe@example.com",
                            MobileNumber = "1234567890",
                            Name = "John Doe",
                            Photo = "https://randomuser.me/api/portraits/men/1.jpg",
                            SecondaryMobileNumber = "0987654321"
                        },
                        new
                        {
                            Id = 2,
                            Email = "jane.smith@example.com",
                            MobileNumber = "2345678901",
                            Name = "Jane Smith",
                            Photo = "https://randomuser.me/api/portraits/women/2.jpg",
                            SecondaryMobileNumber = "1987654321"
                        },
                        new
                        {
                            Id = 3,
                            Email = "michael.johnson@example.com",
                            MobileNumber = "3456789012",
                            Name = "Michael Johnson",
                            Photo = "https://randomuser.me/api/portraits/men/3.jpg",
                            SecondaryMobileNumber = "2987654321"
                        },
                        new
                        {
                            Id = 4,
                            Email = "emily.davis@example.com",
                            MobileNumber = "4567890123",
                            Name = "Emily Davis",
                            Photo = "https://randomuser.me/api/portraits/women/4.jpg",
                            SecondaryMobileNumber = "3987654321"
                        },
                        new
                        {
                            Id = 5,
                            Email = "david.wilson@example.com",
                            MobileNumber = "5678901234",
                            Name = "David Wilson",
                            Photo = "https://randomuser.me/api/portraits/men/5.jpg",
                            SecondaryMobileNumber = "4987654321"
                        },
                        new
                        {
                            Id = 6,
                            Email = "sophia.brown@example.com",
                            MobileNumber = "6789012345",
                            Name = "Sophia Brown",
                            Photo = "https://randomuser.me/api/portraits/women/6.jpg",
                            SecondaryMobileNumber = "5987654321"
                        },
                        new
                        {
                            Id = 7,
                            Email = "james.anderson@example.com",
                            MobileNumber = "7890123456",
                            Name = "James Anderson",
                            Photo = "https://randomuser.me/api/portraits/men/7.jpg",
                            SecondaryMobileNumber = "6987654321"
                        },
                        new
                        {
                            Id = 8,
                            Email = "olivia.martinez@example.com",
                            MobileNumber = "8901234567",
                            Name = "Olivia Martinez",
                            Photo = "https://randomuser.me/api/portraits/women/8.jpg",
                            SecondaryMobileNumber = "7987654321"
                        },
                        new
                        {
                            Id = 9,
                            Email = "benjamin.garcia@example.com",
                            MobileNumber = "9012345678",
                            Name = "Benjamin Garcia",
                            Photo = "https://randomuser.me/api/portraits/men/9.jpg",
                            SecondaryMobileNumber = "8987654321"
                        },
                        new
                        {
                            Id = 10,
                            Email = "charlotte.miller@example.com",
                            MobileNumber = "0123456789",
                            Name = "Charlotte Miller",
                            Photo = "https://randomuser.me/api/portraits/women/10.jpg",
                            SecondaryMobileNumber = "9987654321"
                        },
                        new
                        {
                            Id = 11,
                            Email = "rahul.deshmukh11@example.com",
                            MobileNumber = "9922334455",
                            Name = "Rahul Deshmukh",
                            Photo = "https://randomuser.me/api/portraits/men/11.jpg",
                            SecondaryMobileNumber = "9988776655"
                        },
                        new
                        {
                            Id = 12,
                            Email = "sneha.patil12@example.com",
                            MobileNumber = "9823445566",
                            Name = "Sneha Patil",
                            Photo = "https://randomuser.me/api/portraits/women/12.jpg",
                            SecondaryMobileNumber = "9887665544"
                        },
                        new
                        {
                            Id = 13,
                            Email = "siddharth.kulkarni13@example.com",
                            MobileNumber = "9734556677",
                            Name = "Siddharth Kulkarni",
                            Photo = "https://randomuser.me/api/portraits/men/13.jpg",
                            SecondaryMobileNumber = "9776554433"
                        },
                        new
                        {
                            Id = 14,
                            Email = "pooja.jadhav14@example.com",
                            MobileNumber = "9645667788",
                            Name = "Pooja Jadhav",
                            Photo = "https://randomuser.me/api/portraits/women/14.jpg",
                            SecondaryMobileNumber = "9665443322"
                        },
                        new
                        {
                            Id = 15,
                            Email = "akshay.shinde15@example.com",
                            MobileNumber = "9556778899",
                            Name = "Akshay Shinde",
                            Photo = "https://randomuser.me/api/portraits/men/15.jpg",
                            SecondaryMobileNumber = "9554332211"
                        },
                        new
                        {
                            Id = 16,
                            Email = "neha.pawar16@example.com",
                            MobileNumber = "9467889900",
                            Name = "Neha Pawar",
                            Photo = "https://randomuser.me/api/portraits/women/16.jpg",
                            SecondaryMobileNumber = "9443221100"
                        },
                        new
                        {
                            Id = 17,
                            Email = "vishal.gaikwad17@example.com",
                            MobileNumber = "9378990011",
                            Name = "Vishal Gaikwad",
                            Photo = "https://randomuser.me/api/portraits/men/17.jpg",
                            SecondaryMobileNumber = "9332110099"
                        },
                        new
                        {
                            Id = 18,
                            Email = "priya.joshi18@example.com",
                            MobileNumber = "9289001122",
                            Name = "Priya Joshi",
                            Photo = "https://randomuser.me/api/portraits/women/18.jpg",
                            SecondaryMobileNumber = "9221009988"
                        },
                        new
                        {
                            Id = 19,
                            Email = "aditya.pawar19@example.com",
                            MobileNumber = "9190112233",
                            Name = "Aditya Pawar",
                            Photo = "https://randomuser.me/api/portraits/men/19.jpg",
                            SecondaryMobileNumber = "9110098777"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

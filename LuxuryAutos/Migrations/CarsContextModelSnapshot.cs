﻿// <auto-generated />
using System;
using LuxuryAutos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LuxuryAutos.Migrations
{
    [DbContext(typeof(CarsContext))]
    partial class CarsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LuxuryAutos.Models.Cars", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CarPicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("Make")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("TopSpeed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarPicture = "/Images/f12Optimized.jpg",
                            LocationId = 2,
                            Make = 0,
                            Model = "F12",
                            Price = 289999.0,
                            TopSpeed = 211
                        },
                        new
                        {
                            Id = 2,
                            CarPicture = "/Images/aventadorOptimized.jpg",
                            LocationId = 3,
                            Make = 1,
                            Model = "Aventador",
                            Price = 556000.0,
                            TopSpeed = 220
                        },
                        new
                        {
                            Id = 3,
                            CarPicture = "/Images/gt3Optimized.jpg",
                            LocationId = 4,
                            Make = 2,
                            Model = "911 GT3 RS",
                            Price = 250000.0,
                            TopSpeed = 184
                        },
                        new
                        {
                            Id = 4,
                            CarPicture = "/Images/vanquish-zagata.jpg",
                            LocationId = 1,
                            Make = 2,
                            Model = "Vanquish",
                            Price = 350000.0,
                            TopSpeed = 225
                        });
                });

            modelBuilder.Entity("LuxuryAutos.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            Address = "9155 Audubon Rd",
                            LocationName = "Detroit",
                            Manager = "Joonas Qemu'el"
                        },
                        new
                        {
                            LocationId = 2,
                            Address = "5154 Greystone Ct",
                            LocationName = "Traverse City",
                            Manager = "Sophia August"
                        },
                        new
                        {
                            LocationId = 3,
                            Address = "602 3rd Ave",
                            LocationName = "Grand Rapids",
                            Manager = "Milana David"
                        },
                        new
                        {
                            LocationId = 4,
                            Address = "500 Tamarack Ct",
                            LocationName = "Lansing",
                            Manager = "Jason Lawson"
                        });
                });

            modelBuilder.Entity("LuxuryAutos.Models.Cars", b =>
                {
                    b.HasOne("LuxuryAutos.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });
#pragma warning restore 612, 618
        }
    }
}

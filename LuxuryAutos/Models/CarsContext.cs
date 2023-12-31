﻿using Microsoft.EntityFrameworkCore;
using LuxuryAutos.Models;

namespace LuxuryAutos.Models
{
    public class CarsContext : DbContext
    {
        public CarsContext(DbContextOptions<CarsContext>options):base(options) { }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasData(
                new Models.Location
                { 
                    LocationId = 1,
                    LocationName = "Detroit",
                    Manager = "Joonas Qemu'el",
                    Address = "9155 Audubon Rd"

                },
                 new Models.Location
                 {
                     LocationId = 2,
                     LocationName = "Traverse City",
                     Manager = "Sophia August",
                     Address = "5154 Greystone Ct"

                 },
                  new Models.Location
                  {
                      LocationId = 3,
                      LocationName = "Grand Rapids",
                      Manager = "Milana David",
                      Address = "602 3rd Ave"

                  },
                   new Models.Location
                   {
                       LocationId = 4,
                       LocationName = "Lansing",
                       Manager = "Jason Lawson",
                       Address = "500 Tamarack Ct"

                   }                 
                );
            modelBuilder.Entity<Employees>().HasData(
                new Models.Employees
                {
                    Id = 1,
                    FirstName = "Luxanna",
                    LastName = "Crownguard",
                    Email = "lcrownguard@luxAuto.com",
                    Position = "Sales Associate",
                    LocationId = 2
                },
                new Models.Employees
                {
                    Id = 2,
                    FirstName = "Ahri",
                    LastName = "Crownguard",
                    Email = "acrownguard@luxAuto.com",
                    Position = "Sales Associate",
                    LocationId = 1
                },
                new Models.Employees
                {
                    Id = 3,
                    FirstName = "Ashe",
                    LastName = "Avarosan",
                    Email = "aavarosn@luxAuto.com",
                    Position = "Sales Associate",
                    LocationId = 3
                },
                new Models.Employees
                {
                    Id = 4,
                    FirstName = "Fiora",
                    LastName = "Laurent",
                    Email = "flaurent@luxAuto.com",
                    Position = "Sales Associate",
                    LocationId = 4
                },
                new Models.Employees
                {
                    Id = 5,
                    FirstName = "Garen",
                    LastName = "Crownguard",
                    Email = "gcrownguard@luxAuto.com",
                    Position = "Mechanic",
                    LocationId = 2
                }
                );
            modelBuilder.Entity<Cars>().HasData(
                new Models.Cars()
                {
                    Id = 1,
                    LocationId = 2,
                    Model = "F12",
                    Make = Make.Ferrari,
                    TopSpeed = 211,
                    Price = 289999,
                    CarPicture = "/Images/f12Optimized.jpg"
                },
                new Models.Cars()
                {
                    Id = 2,
                    LocationId = 3,
                    Model = "Aventador",
                    Make = Make.Lamborghini,
                    TopSpeed = 220,
                    Price = 556000,
                    CarPicture = "/Images/aventadorOptimized.jpg"
                },
                new Models.Cars()
                {
                    Id = 3,
                    LocationId = 4,
                    Model = "911 GT3 RS",
                    Make = Make.Porsche,
                    TopSpeed = 184,
                    Price = 250000,
                    CarPicture = "/Images/gt3Optimized.jpg"
                },
                new Models.Cars()
                {
                    Id = 4,
                    LocationId = 1,
                    Model = "Vanquish",
                    Make = Make.Porsche,
                    TopSpeed = 225,
                    Price = 350000,
                    CarPicture = "/Images/vanquish-zagata.jpg"
                }
                );
        }

        public DbSet<LuxuryAutos.Models.Employees>? Employees { get; set; }
    }
}

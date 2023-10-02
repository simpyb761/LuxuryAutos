using Microsoft.EntityFrameworkCore;

namespace LuxuryAutos.Models
{
    public class CarsContext : DbContext
    {
        public CarsContext(DbContextOptions<CarsContext>options):base(options) { }
        public DbSet<Cars> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>().HasData(
                new Models.Cars()
                {
                    Id = 1,
                    Model = "F12",
                    Make = Make.Ferrari,
                    TopSpeed = 211,
                    Price = 289999,
                    CarPicture = "/Images/f12Optimized.jpg"
                },
                new Models.Cars()
                {
                    Id = 2,
                    Model = "Aventador",
                    Make = Make.Lamborghini,
                    TopSpeed = 220,
                    Price = 556000,
                    CarPicture = "/Images/aventadorOptimized.jpg"
                },
                new Models.Cars()
                {
                    Id = 3,
                    Model = "911 GT3 RS",
                    Make = Make.Porsche,
                    TopSpeed = 184,
                    Price = 250000,
                    CarPicture = "/Images/gt3Optimized.jpg"
                },
                new Models.Cars()
                {
                    Id = 4,
                    Model = "Vanquish",
                    Make = Make.Porsche,
                    TopSpeed = 225,
                    Price = 350000,
                    CarPicture = "/Images/vanquish-zagata.jpg"
                }
                );
        }
    }
}

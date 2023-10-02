using System.ComponentModel.DataAnnotations;
    
namespace LuxuryAutos.Models
{
    public enum Make
    {
        Ferrari,
        Lamborghini,
        Porsche,
        

    }
    public class Cars
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Model { get; set; }
        [Required]
        public Make Make { get; set; }
        [Required]
        public double Price { get; set; }
        public int? TopSpeed { get; set; }
        public string CarPicture { get; set; }


    }
}


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [DataType(DataType.Currency)]
        [Range(100000,4000000, ErrorMessage ="Cars cannot be less than $100,000 or more than $4,000,000!")]
        public double Price { get; set; }
        [Display(Name ="Top Speed")]
        [Column("Top Speed")]
        [Range(0,300, ErrorMessage = "Cars must have a speed between 0 and 250")]
        public int? TopSpeed { get; set; }
        [Display(Name = "Car Picture")]
        [Column("Picture Reference")]
        [Required(ErrorMessage ="Please provide a picture for clients shopping!")]
        public string CarPicture { get; set; }
        [Display(Name ="Location Id")]
        public int LocationId {  get; set; }
        public Location? Location { get; set; }

    }
}


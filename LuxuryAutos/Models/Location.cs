using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LuxuryAutos.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only Letters allowed in location name.")]
        [Display(Name = "Location Name")]
        [StringLength(30)]
        [Column("Location Name")]
        public string LocationName { get; set; }
        [RegularExpression("^[a-zA-Z ']*$", ErrorMessage = "Only Letters allowed in manager name.")]
        [StringLength(25)]
        public string Manager {  get; set; }
        [StringLength(30)]
        public string Address { get; set; }
    }
}

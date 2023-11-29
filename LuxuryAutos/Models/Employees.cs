using System.ComponentModel.DataAnnotations;

namespace LuxuryAutos.Models
{
    public class Employees
    {
        public int Id { get; set; }
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only Letters allowed in first name.")]
        [Display(Name = "First Name")]
        [StringLength(30)]
        public string FirstName { get; set; }
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only Letters allowed in last name.")]
        [Display(Name = "Last Name")]
        [StringLength(30)]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public int LocationId { get; set; }
        public Location? Location { get; set; }
    }
}

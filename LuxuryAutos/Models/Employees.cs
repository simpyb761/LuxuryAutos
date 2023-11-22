namespace LuxuryAutos.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email
        { get; set; }
        public string Position { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}

namespace MVCAssignment4.Models
{
    public class Owner
    {
        public int OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; } //Database Name
    }
}

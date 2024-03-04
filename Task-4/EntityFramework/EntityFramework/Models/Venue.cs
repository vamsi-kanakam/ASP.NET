namespace EntityFramework.Models
{
    public class Venue
    {
        public int VenueId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int MaxCapacity { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}

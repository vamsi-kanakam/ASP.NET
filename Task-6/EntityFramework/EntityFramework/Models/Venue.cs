using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Models
{
    public class Venue
    {
        public int VenueId { get; set; }
        [Display (Name = "Venue Name")]
        [MaxLength (60,ErrorMessage = "Venue name must be 60 character or less")]
        [RegularExpression("^[a-zA-Z0-9\\s\\-']+$",ErrorMessage = "Venue name must be Alpha or Alpha-Numeric")]
        public string Name { get; set; }
        public string Address { get; set; }

        [Display(Name = "Venue Name")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Venue Capacity must be Numeric")]

        public int MaxCapacity { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}

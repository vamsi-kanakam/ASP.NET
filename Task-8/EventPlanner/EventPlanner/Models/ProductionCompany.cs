namespace EventPlanner.Models
{
    public class ProductionCompany
    {
        public int ProductionCompanyId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int StaffSize { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}

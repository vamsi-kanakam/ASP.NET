namespace EntityFramework.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public DateTime EventDateTime { get; set; }
        public double CurrentAttendance { get; set; }
        public decimal TicketPrice { get; set; }

        public int? VenueId { get; set; }

        public virtual Venue Venue { get; set; }

        public int? PerformingActId { get; set; }
        public virtual PerformingAct PerformingAct { get; set; }
        public int? ProductionCompanyId { get; set; }
        public virtual ProductionCompany ProductionCompany { get; set; }
    }
}

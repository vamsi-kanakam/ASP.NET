namespace EntityFramework.Models
{
    public class PerformingAct
    {
        public int PerformingActId { get; set; }
        public string Name { get; set; }
        public int NumberOfPerformers { get; set; }
        public int Manager { get; set; }
        public string PerformerType { get; set; }
        public double AverageAttendance { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}

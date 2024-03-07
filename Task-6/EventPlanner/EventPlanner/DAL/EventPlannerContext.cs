using EventPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace EventPlanner.DAL
{
    public class EventPlannerContext:DbContext
    {
        public EventPlannerContext(DbContextOptions<EventPlannerContext> options) : base(options) { }

        public DbSet<ProductionCompany> ProductionCompanies { get; set; }
        public DbSet<PerformingAct> PerformingActs { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}

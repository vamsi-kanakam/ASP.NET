using Microsoft.EntityFrameworkCore;
using EntityFramework.Models;
using Microsoft.Extensions.Options;

namespace EntityFramework.Models.DAL
{
    public class EntityFrameworkContext : DbContext
    {
        public EntityFrameworkContext(DbContextOptions <EntityFrameworkContext> options) : base (options) { }

        public DbSet<ProductionCompany> ProductionCompany { get; set; }
        public DbSet<PerformingAct> PerformingActs { get; set; }
        public DbSet<Venue> Venue { get; set; }
        public DbSet<Event> Event { get; set; }

    }
}

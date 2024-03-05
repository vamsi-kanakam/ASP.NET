using Microsoft.EntityFrameworkCore;
using MVCAssignment4.Models;

namespace MVCAssignment4.DAL
{
    public class MVCAssignment4Context:DbContext //Database Creation
    {
        public MVCAssignment4Context(DbContextOptions<MVCAssignment4Context> options) : base(options) { }

        public DbSet<Owner> Owner { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
    }
}

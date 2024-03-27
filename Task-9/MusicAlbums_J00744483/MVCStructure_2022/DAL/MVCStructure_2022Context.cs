using Microsoft.EntityFrameworkCore;
using MVCStructure_2022.Models;

namespace MVCStructure_2022.DAL
{
    public class MVCStructure_2022Context : DbContext
    {
        public MVCStructure_2022Context(DbContextOptions<MVCStructure_2022Context> options) : base(options) { }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}

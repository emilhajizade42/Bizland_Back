using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<OurTeamCard> OurTeamCards { get; set; }
    }
}

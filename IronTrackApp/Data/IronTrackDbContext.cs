using IronTrackApp.Models;
using Microsoft.EntityFrameworkCore;

namespace IronTrackApp.Data
{
    public class IronTrackDbContext : DbContext
    {
        public IronTrackDbContext(DbContextOptions<IronTrackDbContext> options) : base(options)
        {

        }

        public DbSet<Exercise> Exercises { get; set; }
    }
}

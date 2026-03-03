using IronTrack.Domain;
using Microsoft.EntityFrameworkCore;

namespace IronTrack.Persistence.DatabaseContext;

public class IronTrackDatabaseContext : DbContext
{
    public IronTrackDatabaseContext(DbContextOptions<IronTrackDatabaseContext> options) : base(options)
    {

    }

    public DbSet<BodyWeightLog> BodyWeightLogs { get; set; }
    public DbSet<Exercise> Exercises { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IronTrackDatabaseContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in base.ChangeTracker.Entries<BaseEntity>()
            .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
        {
            entry.Entity.ModifiedDate = DateTime.UtcNow;

            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedDate = DateTime.UtcNow;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}

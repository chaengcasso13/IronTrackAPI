using IronTrack.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IronTrack.Persistence.Configurations;

public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
{
    public void Configure(EntityTypeBuilder<Exercise> builder)
    {
        // let SQL server generate timestamps:
        builder.Property(x => x.CreatedDate)
            .HasDefaultValueSql("GETUTCDATE()");
        builder.Property(x => x.ModifiedDate)
            .HasDefaultValueSql("GETUTCDATE()");


        builder.HasData(
                new Exercise()
                {
                    Id = 2,
                    ExerciseName = "Barbell Squats",
                    MuscleGroup = "Quads"
                }
            );
    }
}

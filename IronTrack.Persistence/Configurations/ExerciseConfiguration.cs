using IronTrack.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IronTrack.Persistence.Configurations;

public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
{
    public void Configure(EntityTypeBuilder<Exercise> builder)
    {
        builder.HasData(
                new Exercise()
                {
                    ExerciseID = 2,
                    ExerciseName = "Barbell Squats",
                    MuscleGroup = "Quads",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                }
            );
    }
}

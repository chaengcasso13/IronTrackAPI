
namespace IronTrack.Domain;

public class Exercise : BaseEntity
{
    public int ExerciseID { get; set; }
    public string? ExerciseName { get; set; }
    public string? MuscleGroup { get; set; }
    public bool IsCompound { get; set; }
}

namespace IronTrack.Application.Features.Exercise.Queries.GetAllExercises
{
    public class ExerciseDto
    {
        public int ExerciseID { get; set; }
        public string? ExerciseName { get; set; }
        public string? MuscleGroup { get; set; }
        public bool IsCompound { get; set; }
    }
}

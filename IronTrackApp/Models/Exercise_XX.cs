namespace IronTrackApp.Models
{
    public class Exercise_XX
    {
        public int ExerciseID { get; set; }
        public string? ExerciseName { get; set; }
        public string? MuscleGroup { get; set; }
        public bool IsCompound { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}

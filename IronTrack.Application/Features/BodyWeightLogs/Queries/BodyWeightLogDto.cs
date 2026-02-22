namespace IronTrack.Application.Features.BodyWeightLogs.Queries
{
    public class BodyWeightLogDto
    {
        public int BodyWeightLogID { get; set; }
        public int UserID { get; set; }
        public decimal WeightKg { get; set; }
        public DateTime LoggedDate { get; set; }
    }
}

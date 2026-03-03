namespace IronTrack.Domain
{
    public class BodyWeightLog : BaseEntity
    {
        public int BodyWeightLogID { get; set; }
        public int UserID { get; set; }
        public decimal WeightKg { get; set; }
        public DateTime LoggedDate { get; set; }
    }
}

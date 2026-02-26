using IronTrack.Domain;

namespace IronTrack.Application.Contracts.Persistence
{
    public interface IBodyWeightLogRepository : IGenericRepository<BodyWeightLog>
    {
        Task<bool> IsBodyWeightLogUnique(decimal name);
    }
}

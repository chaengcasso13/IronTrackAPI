using IronTrack.Application.Contracts.Persistence;
using IronTrack.Domain;
using IronTrack.Persistence.DatabaseContext;

namespace IronTrack.Persistence.Repositories;

public class BodyWeightLogRepository : GenericRepository<BodyWeightLog>, IBodyWeightLogRepository
{
    public BodyWeightLogRepository(IronTrackDatabaseContext context) : base(context)
    {
    }

    public Task<bool> IsBodyWeightLogUnique(decimal name)
    {
        throw new NotImplementedException();
    }
}


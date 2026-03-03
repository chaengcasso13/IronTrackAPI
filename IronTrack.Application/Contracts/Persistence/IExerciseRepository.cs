using IronTrack.Domain;

namespace IronTrack.Application.Contracts.Persistence;

public interface IExerciseRepository : IGenericRepository<Exercise>
{
    // NOTE: For testing purpose only:
    Task<bool> IsExerciseUnique(string exerciseName);
}

using IronTrack.Application.Contracts.Persistence;
using IronTrack.Domain;
using IronTrack.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace IronTrack.Persistence.Repositories;

public class ExerciseRepository : GenericRepository<Exercise>, IExerciseRepository
{
    public ExerciseRepository(IronTrackDatabaseContext context) : base(context)
    {
    }

    public async Task<bool> IsExerciseUnique(string exerciseName)
    {
        return await _context.Exercises.AnyAsync(q => q.ExerciseName == exerciseName);
    }
}


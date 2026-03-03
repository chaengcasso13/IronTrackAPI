using IronTrack.Application.Contracts.Persistence;
using IronTrack.Persistence.DatabaseContext;
using IronTrack.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IronTrack.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<IronTrackDatabaseContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("IronTrackDatabaseConnectionString"));
        });

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IExerciseRepository, ExerciseRepository>();
        services.AddScoped<IBodyWeightLogRepository, BodyWeightLogRepository>();

        return services;
    }
}

using MediatR;

namespace IronTrack.Application.Features.Exercise.Queries.GetAllExercises
{
    public class GetExerciseQuery : IRequest<List<ExerciseDto>>
    {
    }
}

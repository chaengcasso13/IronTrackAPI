using AutoMapper;
using IronTrack.Application.Contracts.Persistence;
using MediatR;

namespace IronTrack.Application.Features.Exercise.Queries.GetAllExercises
{
    public class GetExerciseQueryHandler : IRequestHandler<GetExerciseQuery, List<ExerciseDto>>
    {
        private readonly IMapper _mapper;
        private readonly IExerciseRepository _exerciseRepository;

        public GetExerciseQueryHandler(IMapper mapper, IExerciseRepository exerciseRepository)
        {
            this._mapper = mapper;
            this._exerciseRepository = exerciseRepository;
        }
        async Task<List<ExerciseDto>> IRequestHandler<GetExerciseQuery, List<ExerciseDto>>.Handle(GetExerciseQuery request, CancellationToken cancellationToken)
        {
            // Query the db
            var exercise = await _exerciseRepository.GetAllAsync();

            // convert data obj to dto obj
            var data = _mapper.Map<List<ExerciseDto>>(exercise);

            // return list of dto
            return data;
        }
    }
}

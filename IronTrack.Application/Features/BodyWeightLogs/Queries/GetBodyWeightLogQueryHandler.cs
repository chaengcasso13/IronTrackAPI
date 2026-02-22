using AutoMapper;
using IronTrack.Application.Contracts.Persistence;
using MediatR;

namespace IronTrack.Application.Features.BodyWeightLogs.Queries
{
    public class GetBodyWeightLogQueryHandler : IRequestHandler<GetBodyWeightLogQuery, BodyWeightLogDto>
    {
        private readonly IMapper _mapper;
        private readonly IBodyWeightLogRepository _bodyWeightLogRepository;

        public GetBodyWeightLogQueryHandler(IMapper mapper, IBodyWeightLogRepository bodyWeightLogRepository)
        {
            this._mapper = mapper;
            this._bodyWeightLogRepository = bodyWeightLogRepository;
        }

        public async Task<BodyWeightLogDto> Handle(GetBodyWeightLogQuery request, CancellationToken cancellationToken)
        {
            // query db
            var bodyWeightLog = await _bodyWeightLogRepository.GetByIdAsync(request.BodyWeightLogId);

            // convert db obj to dto obj
            var data = _mapper.Map<BodyWeightLogDto>(bodyWeightLog);

            // return dto obj
            return data;
        }
    }
}

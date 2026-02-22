using AutoMapper;
using IronTrack.Application.Contracts.Persistence;
using IronTrack.Domain;
using MediatR;

namespace IronTrack.Application.Features.BodyWeightLogs.Commands.UpdateBodyWeightLog
{
    public class UpdateBodyWeightCommandHandler : IRequestHandler<UpdateBodyWeightLogCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IBodyWeightLogRepository _bodyWeightLogRepository;

        public UpdateBodyWeightCommandHandler(IMapper mapper, IBodyWeightLogRepository bodyWeightLogRepository)
        {
            this._mapper = mapper;
            this._bodyWeightLogRepository = bodyWeightLogRepository;
        }

        public async Task<Unit> Handle(UpdateBodyWeightLogCommand request, CancellationToken cancellationToken)
        {
            // validate request

            // convert dto into entity obj
            var updateBodyWeight = _mapper.Map<BodyWeightLog>(request);

            // update to db
            await _bodyWeightLogRepository.UpdateAsync(updateBodyWeight);

            // return if success
            return Unit.Value;
        }
    }
}

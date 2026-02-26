using AutoMapper;
using IronTrack.Application.Contracts.Persistence;
using IronTrack.Application.Exceptions;
using IronTrack.Domain;
using MediatR;

namespace IronTrack.Application.Features.BodyWeightLogs.Commands.CreateBodyWeightLog
{
    public class CreatebodyWeightLogCommandHandler : IRequestHandler<CreateBodyWeightLogCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IBodyWeightLogRepository _bodyWeightLogRepository;

        public CreatebodyWeightLogCommandHandler(IMapper mapper, IBodyWeightLogRepository bodyWeightLogRepository)
        {
            this._mapper = mapper;
            this._bodyWeightLogRepository = bodyWeightLogRepository;
        }
        public async Task<int> Handle(CreateBodyWeightLogCommand request, CancellationToken cancellationToken)
        {
            // validate incoming data
            var validator = new CreateBodyWeightLogCommandValidator(_bodyWeightLogRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (!validationResult.IsValid)
                throw new BadRequestException("Inavalid weight input.", validationResult);

            // convert to domain entity obj
            var bodyWeightLog = _mapper.Map<BodyWeightLog>(request);

            // add to db
            await _bodyWeightLogRepository.CreateAsync(bodyWeightLog);

            // return record id
            return bodyWeightLog.BodyWeightLogID;
        }
    }
}

using IronTrack.Application.Contracts.Persistence;
using MediatR;

namespace IronTrack.Application.Features.BodyWeightLogs.Commands.DeleteBodyWeightLog
{
    public class DeleteBodyWeightLogCommandHandler : IRequestHandler<DeleteBodyWeightLogCommand, Unit>
    {
        private readonly IBodyWeightLogRepository _bodyWeightLogRepository;

        public DeleteBodyWeightLogCommandHandler(IBodyWeightLogRepository bodyWeightLogRepository)
        {
            this._bodyWeightLogRepository = bodyWeightLogRepository;
        }
        public async Task<Unit> Handle(DeleteBodyWeightLogCommand request, CancellationToken cancellationToken)
        {
            // retrieve domain entity obj
            var leaveTypeToDelete = await _bodyWeightLogRepository.GetByIdAsync(request.UserID);

            // verify if record exist

            // remove from DB
            await _bodyWeightLogRepository.DeleteAsync(request.UserID);

            // return if success
            return Unit.Value;
        }
    }
}

using MediatR;

namespace IronTrack.Application.Features.BodyWeightLogs.Commands.DeleteBodyWeightLog
{
    public class DeleteBodyWeightLogCommand : IRequest<Unit>
    {
        public int UserID { get; set; }

    }
}

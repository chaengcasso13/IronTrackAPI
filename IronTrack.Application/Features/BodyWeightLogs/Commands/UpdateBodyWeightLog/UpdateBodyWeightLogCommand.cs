using MediatR;

namespace IronTrack.Application.Features.BodyWeightLogs.Commands.UpdateBodyWeightLog
{
    public class UpdateBodyWeightLogCommand : IRequest<Unit>
    {
        public int BodyWeightLogID { get; set; }
        public int UserID { get; set; }

    }
}

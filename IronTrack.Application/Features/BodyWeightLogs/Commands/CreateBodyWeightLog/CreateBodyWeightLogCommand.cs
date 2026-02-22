using MediatR;

namespace IronTrack.Application.Features.BodyWeightLogs.Commands.CreateBodyWeightLog
{
    public class CreateBodyWeightLogCommand : IRequest<int>
    {
        public decimal WeightKg { get; set; }

    }
}

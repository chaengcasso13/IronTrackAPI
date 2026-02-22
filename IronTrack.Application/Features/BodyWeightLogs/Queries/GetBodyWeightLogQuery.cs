using MediatR;

namespace IronTrack.Application.Features.BodyWeightLogs.Queries
{
    public class GetBodyWeightLogQuery : IRequest<BodyWeightLogDto>
    {
        public int BodyWeightLogId { get; set; }
    }
}

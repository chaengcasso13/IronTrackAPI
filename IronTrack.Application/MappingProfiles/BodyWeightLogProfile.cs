using AutoMapper;
using IronTrack.Application.Features.BodyWeightLogs.Queries;
using IronTrack.Domain;

namespace IronTrack.Application.MappingProfiles
{
    public class BodyWeightLogProfile : Profile
    {
        public BodyWeightLogProfile()
        {
            CreateMap<BodyWeightLogDto, BodyWeightLog>().ReverseMap();
        }
    }
}

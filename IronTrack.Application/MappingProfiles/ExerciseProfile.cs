using AutoMapper;
using IronTrack.Application.Features.Exercise.Queries.GetAllExercises;
using IronTrack.Domain;

namespace IronTrack.Application.MappingProfiles
{
    public class ExerciseProfile : Profile
    {
        public ExerciseProfile()
        {
            CreateMap<ExerciseDto, Exercise>().ReverseMap();
        }
    }
}

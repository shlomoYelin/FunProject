using AutoMapper;
using FunProject.Application.ActivityLogModule.Dtos;
using FunProject.Domain.Entities;

namespace FunProject.Infrastructure.Mapper.Mapping
{
    public class ActivityLogMap : Profile
    {
        public ActivityLogMap()
        {
            CreateMap<ActivityLog, ActivityLogDto>()
                .ForMember(d => d.Id, s => s.MapFrom(x => x.Id))
                .ForMember(d => d.ActivityDate, s => s.MapFrom(x => x.ActivityDate))
                .ForMember(d => d.ActionType, s => s.MapFrom(x => x.ActionType))
                .ForMember(d => d.Message, s => s.MapFrom(x => x.Message));

            CreateMap<ActivityLogDto, ActivityLog>();
        }
    }
}

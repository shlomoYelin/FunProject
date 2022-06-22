using AutoMapper;
using FunProject.Application.CustomersModule.Dtos;
using FunProject.Domain.Entities;

namespace FunProject.Infrastructure.Mapper.Mapping
{
    public class CustomerMap : Profile
    {
        public CustomerMap()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(d => d.Id, s => s.MapFrom(x => x.Id))
                .ForMember(d => d.FirstName, s => s.MapFrom(x => x.FirstName))
                .ForMember(d => d.LastName, s => s.MapFrom(x => x.LastName))
                .ForMember(d => d.Type, s => s.MapFrom(x => x.Type));



            CreateMap<CustomerDto, Customer>()
                .ForMember(d => d.Id, s => s.MapFrom(x => x.Id))
                .ForMember(d => d.FirstName, s => s.MapFrom(x => x.FirstName))
                .ForMember(d => d.LastName, s => s.MapFrom(x => x.LastName))
                .ForMember(d => d.Type, s => s.MapFrom(x => x.Type));
        }
    }
}
using AutoMapper;
using FunProject.Application.OrdersModule.Dtos;
using FunProject.Domain.Entities;

namespace FunProject.Infrastructure.Mapper.Mapping
{
    public class OrderMap : Profile
    {
        public OrderMap()
        {
            CreateMap<Order, OrderDto>()
                .ForMember(d => d.Id, s => s.MapFrom(x => x.Id))
                .ForMember(d => d.CustomerId, s => s.MapFrom(x => x.CustomerId))
                .ForMember(d => d.ProductOrders, s => s.MapFrom(x => x.ProductOrders))
                .ForMember(d => d.Date, s => s.MapFrom(x => x.Date))
                .ForMember(d => d.FirstName, s => s.MapFrom(x => x.Customer.FirstName))
                .ForMember(d => d.LastName, s => s.MapFrom(x => x.Customer.LastName));

            CreateMap<OrderDto, Order>()
                .ForMember(d => d.Id, s => s.MapFrom(x => x.Id))
                .ForMember(d => d.CustomerId, s => s.MapFrom(x => x.CustomerId))
                .ForMember(d => d.Payment, s => s.MapFrom(x => x.Payment))
                .ForMember(d => d.ProductOrders, s => s.MapFrom(x => x.ProductOrders))
                .ForMember(d => d.Date, s => s.MapFrom(x => x.Date));

        }
    }
}
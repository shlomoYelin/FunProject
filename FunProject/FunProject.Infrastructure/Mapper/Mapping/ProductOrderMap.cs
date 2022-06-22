using AutoMapper;
using FunProject.Application.ProductOrderModule.Dtos;
using FunProject.Domain.Entities;

namespace FunProject.Infrastructure.Mapper.Mapping
{
    public class ProductOrderMap : Profile
    {
        public ProductOrderMap()
        {
            CreateMap<ProductOrder, ProductOrderDto>()
                .ForMember(d => d.Id, s => s.MapFrom(x => x.Id))
                .ForMember(d => d.ProductId, s => s.MapFrom(x => x.ProductId))
                .ForMember(d => d.OrderId, s => s.MapFrom(x => x.OrderId))
                .ForMember(d => d.Quantity, s => s.MapFrom(x => x.Quantity))
                .ForMember(d => d.ProductDescription, s => s.MapFrom(x => x.Product.Description));

            CreateMap<ProductOrderDto, ProductOrder>()
                 .ForMember(d => d.Id, s => s.MapFrom(x => x.Id))
                 .ForMember(d => d.ProductId, s => s.MapFrom(x => x.ProductId))
                 .ForMember(d => d.OrderId, s => s.MapFrom(x => x.OrderId))
                 .ForMember(d => d.Quantity, s => s.MapFrom(x => x.Quantity));
        }
    }
}

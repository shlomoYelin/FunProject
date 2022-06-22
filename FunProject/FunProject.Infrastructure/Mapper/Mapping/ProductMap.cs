using AutoMapper;
using FunProject.Application.ProductsModule.Dtos;
using FunProject.Domain.Entities;

namespace FunProject.Infrastructure.Mapper.Mapping
{
    public class ProductMap : Profile
    {
        public ProductMap()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(d => d.Id, s => s.MapFrom(x => x.Id))
                .ForMember(d => d.Description, s => s.MapFrom(x => x.Description))
                .ForMember(d => d.Price, s => s.MapFrom(x => x.Price));

            CreateMap<ProductDto, Product>()
                .ForMember(d => d.Id, s => s.MapFrom(x => x.Id))
                .ForMember(d => d.Description, s => s.MapFrom(x => x.Description))
                .ForMember(d => d.Price, s => s.MapFrom(x => x.Price));
        }
    }
}

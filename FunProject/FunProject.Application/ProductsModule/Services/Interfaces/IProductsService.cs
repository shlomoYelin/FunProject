using FunProject.Application.ProductsModule.Dtos;
using FunProject.Domain.Models;
using System.Collections.Generic;

namespace FunProject.Application.ProductsModule.Services.Interfaces
{
    public interface IProductsService
    {
        IList<ProductDto> GetAllProducts();
        ActionStatusModel CreateProduct(ProductDto product);
        ActionStatusModel UpdateProduct(ProductDto product);
        ActionStatusModel DeleteProduct(int id);
        IList<ProductDto> GetProductsBySearchValue(string searchValue);
    }
}
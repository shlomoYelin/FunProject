using FunProject.Application.ProductsModule.Dtos;
using FunProject.Domain.Models;

namespace FunProject.Application.ProductsModule.Validators.Interfaces
{
    public interface ICreateProductValidator
    {
        ActionStatusModel Validate(ProductDto product);
    }
}

using FunProject.Application.ProductsModule.Dtos;
using FunProject.Domain.Models;

namespace FunProject.Application.ProductsModule.WorkFlows.Interfaces
{
    public interface ICreateProductWorkFlow
    {
        ActionStatusModel Create(ProductDto product);
    }
}

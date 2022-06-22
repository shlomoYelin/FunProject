using FunProject.Application.ProductsModule.Dtos;
using FunProject.Domain.Models;

namespace FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces
{
    public interface ICreateProductTask
    {
        ActionStatusModel Create(ProductDto product);
    }
}

using FunProject.Application.ProductsModule.Dtos;
using FunProject.Domain.Models;

namespace FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces
{
    public interface IUpdateProductTask
    {
        ActionStatusModel Update(ProductDto product);
    }
}

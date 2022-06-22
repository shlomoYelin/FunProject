using FunProject.Application.ProductsModule.Dtos;
using FunProject.Domain.Models;

namespace FunProject.Application.ProductsModule.WorkFlows.Interfaces
{
    public interface IUpdateProductWorkFlow
    {
        ActionStatusModel Update(ProductDto product);
    }
}

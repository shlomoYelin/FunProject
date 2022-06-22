using FunProject.Application.ProductsModule.Dtos;

namespace FunProject.Application.ProductsModule.WorkFlows.Interfaces
{
    public interface IGetProductWorkFlow
    {
        ProductDto Get(int? id);
    }
}

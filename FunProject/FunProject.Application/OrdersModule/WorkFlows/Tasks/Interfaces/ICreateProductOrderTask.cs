using FunProject.Application.ProductOrderModule.Dtos;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface ICreateProductOrderTask
    {
        void Create(ProductOrderDto order);
    }
}

using FunProject.Application.ProductOrderModule.Dtos;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IUpdateProductOrderTask
    {
        void Update(ProductOrderDto productOrder);
    }
}

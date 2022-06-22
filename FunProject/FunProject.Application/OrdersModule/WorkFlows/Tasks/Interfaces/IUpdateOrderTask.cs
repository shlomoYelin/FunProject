using FunProject.Application.OrdersModule.Dtos;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IUpdateOrderTask
    {
        void Update(OrderDto order);
    }
}

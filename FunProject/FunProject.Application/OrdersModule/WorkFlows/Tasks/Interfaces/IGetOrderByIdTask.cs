using FunProject.Application.OrdersModule.Dtos;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IGetOrderByIdTask
    {
        OrderDto Get(int id);
    }
}

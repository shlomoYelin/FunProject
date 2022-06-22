using FunProject.Application.OrdersModule.Dtos;

namespace FunProject.Application.OrdersModule.WorkFlows.Interfaces
{
    public interface IGetOrderWorkFlow
    {
        OrderDto Get(int? id);
    }
}

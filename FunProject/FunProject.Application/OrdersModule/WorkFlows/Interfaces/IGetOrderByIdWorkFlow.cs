using FunProject.Application.OrdersModule.Dtos;

namespace FunProject.Application.OrdersModule.WorkFlows.Interfaces
{
    public interface IGetOrderByIdWorkFlow
    {
        OrderDto Get(int id);   
    }
}

using FunProject.Application.OrdersModule.Dtos;

namespace FunProject.Application.OrdersModule.WorkFlows.Interfaces
{
    public interface IOrderPaymentCalculationWorkFlow
    {
        float Calculate(OrderDto order);
    }
}

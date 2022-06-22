using FunProject.Application.OrdersModule.Dtos;

namespace FunProject.Application.OrdersModule.Services.Interfaces
{
    public interface IOrderPaymentCalculationService
    {
        float Calculate(OrderDto order);
    }
}

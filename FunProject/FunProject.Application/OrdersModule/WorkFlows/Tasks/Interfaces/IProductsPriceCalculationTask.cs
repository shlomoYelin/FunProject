using FunProject.Application.OrdersModule.Dtos;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IProductsPriceCalculationTask
    {
        float Calculate(OrderDto order);
    }
}

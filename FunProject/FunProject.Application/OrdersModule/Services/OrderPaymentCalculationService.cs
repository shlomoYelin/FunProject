using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.Services.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Interfaces;

namespace FunProject.Application.OrdersModule.Services
{
    public class OrderPaymentCalculationService : IOrderPaymentCalculationService
    {
        private readonly IOrderPaymentCalculationWorkFlow _orderPaymentCalculationWorkFlow;

        public OrderPaymentCalculationService(IOrderPaymentCalculationWorkFlow orderPaymentCalculationWorkFlow)
        {
            _orderPaymentCalculationWorkFlow = orderPaymentCalculationWorkFlow;
        }
        public float Calculate(OrderDto order)
        {
            return _orderPaymentCalculationWorkFlow.Calculate(order);
        }
    }
}

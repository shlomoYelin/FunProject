using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.Services.Interfaces;
using FunProject.Application.OrdersModule.Validators.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Models;

namespace FunProject.Application.OrdersModule.WorkFlows
{
    public class CreateOrderWorkFlow : ICreateOrderWorkFlow
    {
        private readonly ICreateOrderTask _createOrderTask;
        private readonly ICreateOrderValidator _createOrderValidator;
        private readonly IOrderPaymentCalculationService _orderPaymentCalculationService;

        public CreateOrderWorkFlow(
            ICreateOrderTask createOrderTask,
            ICreateOrderValidator createOrderValidator,
            IOrderPaymentCalculationService orderPaymentCalculationService
            )
        {
            _createOrderTask = createOrderTask;
            _createOrderValidator = createOrderValidator;
            _orderPaymentCalculationService = orderPaymentCalculationService;
        }

        public ActionStatusModel Create(OrderDto order)
        {
            var validationResult = _createOrderValidator.Validation(order);

            if(!validationResult.Success)
            {
                return validationResult;
            }

            order.Payment = _orderPaymentCalculationService.Calculate(order);

            return _createOrderTask.Create(order);
        }
    }
}

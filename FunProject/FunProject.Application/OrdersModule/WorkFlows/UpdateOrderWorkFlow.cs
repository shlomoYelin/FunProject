using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.Services.Interfaces;
using FunProject.Application.OrdersModule.Validators.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Enums;
using FunProject.Domain.Models;
using System.Linq;

namespace FunProject.Application.OrdersModule.WorkFlows
{
    public class UpdateOrderWorkFlow : IUpdateOrderWorkFlow
    {
        private readonly IUpdateOrderTask _updateOrderTask;
        private readonly IUpdateOrderValidator _updateOrderValidator;
        private readonly IOrderPaymentCalculationService _orderPaymentCalculationService;
        private readonly IGetProductOrdersByOrderIdTask _getProductOrdersByOrderIdTask;
        private readonly IProductOrderGetActionTypeTask _productOrderGetActionTypeTask;
        private readonly IGetProductOrdersToDeleteTask _getProductOrdersToDeleteTask;
        private readonly IDeleteProductOrdersTask _deleteProductOrdersTask;
        private readonly ICreateProductOrderTask _createProductOrderTask;
        private readonly IUpdateProductOrderTask _updateProductOrderTask;


        public UpdateOrderWorkFlow(IUpdateOrderTask updateOrderTask,
            IUpdateOrderValidator updateOrderValidator,
            IOrderPaymentCalculationService orderPaymentCalculationService,
            IGetProductOrdersByOrderIdTask getProductOrdersByOrderIdTask,
            IProductOrderGetActionTypeTask productOrderGetActionTypeTask,
            IGetProductOrdersToDeleteTask getProductOrdersToDeleteTask,
            IDeleteProductOrdersTask deleteProductOrdersTask,
            ICreateProductOrderTask createProductOrderTask,
            IUpdateProductOrderTask updateProductOrderTask)
        {
            _updateOrderTask = updateOrderTask;
            _updateOrderValidator = updateOrderValidator;
            _orderPaymentCalculationService = orderPaymentCalculationService;
            _getProductOrdersByOrderIdTask = getProductOrdersByOrderIdTask;
            _productOrderGetActionTypeTask = productOrderGetActionTypeTask;
            _getProductOrdersToDeleteTask = getProductOrdersToDeleteTask;
            _deleteProductOrdersTask = deleteProductOrdersTask;
            _createProductOrderTask = createProductOrderTask;
            _updateProductOrderTask = updateProductOrderTask;
        }
        public ActionStatusModel Update(OrderDto order)
        {
            var actionStatus = _updateOrderValidator.Validation(order);
            if (!actionStatus.Success)
            {
                return actionStatus;
            }

            order.Payment = _orderPaymentCalculationService.Calculate(order);

            var dbProductOrders = _getProductOrdersByOrderIdTask.Get(order.Id);
            var clientProductOrders = order.ProductOrders;

            try
            {
                clientProductOrders.ToList().ForEach(clientProductOrder =>
                {
                    var dbProductOrder = dbProductOrders.FirstOrDefault(productOrder => productOrder.ProductId == clientProductOrder.ProductId);

                    var actionType =
                        _productOrderGetActionTypeTask.Get(dbProductOrder, clientProductOrder);

                    if (actionType == ActionType.Create)
                    {
                        _createProductOrderTask.Create(clientProductOrder);
                    }
                    else if (actionType == ActionType.Update)
                    {
                        _updateProductOrderTask.Update(clientProductOrder);
                    }
                });

                var toDelete = _getProductOrdersToDeleteTask.Get(dbProductOrders, clientProductOrders);

                _deleteProductOrdersTask.Delete(toDelete);

                order.ProductOrders = null;
                _updateOrderTask.Update(order);
            }
            catch (System.Exception ex)
            {
                actionStatus.Success = false;
                actionStatus.Message = ex.Message;
            }
            return actionStatus;
        }
    }
}

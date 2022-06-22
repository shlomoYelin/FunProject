using FunProject.Application.Data.Orders.Query;
using FunProject.Application.OrdersModule.Validators.Validations.Interfaces;
using System;

namespace FunProject.Application.OrdersModule.Validators.Validations
{
    public class OrderIsExistsValidation : IOrderIsExistsValidation
    {
        private readonly IOrderIsExistsQuery _orderIsExistsQuery;

        public OrderIsExistsValidation(IOrderIsExistsQuery orderIsExistsQuery)
        {
            _orderIsExistsQuery = orderIsExistsQuery;
        }
        public void Validate(int orderId)
        {
            if(!_orderIsExistsQuery.IsExists(orderId))
            {
                throw new Exception("Order not found");
            }
        }
    }
}

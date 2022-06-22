using FunProject.Application.Data.ProductOrders.Query;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Entities;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class GetProductOrdersByOrderIdTask : IGetProductOrdersByOrderIdTask
    {
        private readonly IProductOrdersByOrderIdQuery _productOrdersByOrderIdQuery;

        public GetProductOrdersByOrderIdTask(IProductOrdersByOrderIdQuery productOrdersByOrderIdQuery)
        {
            _productOrdersByOrderIdQuery = productOrdersByOrderIdQuery;
        }

        public IList<ProductOrder> Get(int orderId)
        {
            return _productOrdersByOrderIdQuery.Get(orderId);
        }
    }
}

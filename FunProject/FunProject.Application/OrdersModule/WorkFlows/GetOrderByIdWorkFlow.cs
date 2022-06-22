using FunProject.Application.Data.Customers.Query;
using FunProject.Application.Data.Products.Query;
using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.WorkFlows.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using System.Linq;

namespace FunProject.Application.OrdersModule.WorkFlows
{
    public class GetOrderByIdWorkFlow : IGetOrderByIdWorkFlow
    {
        private readonly IGetOrderByIdTask _getOrderByIdTask;
        private readonly IGetCustomerByIdQuery _getCustomerByIdQuery;
        private readonly IGetProductDescQuery _getProductDescQuery;

        public GetOrderByIdWorkFlow(IGetOrderByIdTask getOrderByIdTask, IGetCustomerByIdQuery getCustomerByIdQuery, IGetProductDescQuery getProductDescQuery)
        {
            _getOrderByIdTask = getOrderByIdTask;
            _getCustomerByIdQuery = getCustomerByIdQuery;
            _getProductDescQuery = getProductDescQuery;
        }

        public OrderDto Get(int id)
        {
            var order = _getOrderByIdTask.Get(id);
            var cuatomer = _getCustomerByIdQuery.Get(order.CustomerId);

            order.FirstName = cuatomer.FirstName;
            order.LastName = cuatomer.LastName ;

            order.ProductOrders.ToList()
                .ForEach(productOrder => productOrder.ProductDescription = _getProductDescQuery.Get(productOrder.ProductId));

            return order;
        }
    }
}

using FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.WorkFlows.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Application.OrdersModule.WorkFlows
{
    public class GetAllOrdersWorkFlow : IGetAllOrdersWorkFlow
    {
        private readonly IGetAllOrdersTask _getAllOrdersTask;
        private readonly IGetCustomersFLnameByIdsTask _getCustomersFLnameByIdsTask;
        private readonly IGetProductsByIdsTask _getProductsByIdsTask;

        public GetAllOrdersWorkFlow(IGetAllOrdersTask getAllOrdersTask,
            IGetCustomersFLnameByIdsTask getCustomersFLnameByIdsTask,
            IGetProductsByIdsTask getProductsByIdsTask)
        {
            _getAllOrdersTask = getAllOrdersTask;
            _getCustomersFLnameByIdsTask = getCustomersFLnameByIdsTask;
            _getProductsByIdsTask = getProductsByIdsTask;
        }
        public IList<OrderDto> Get()
        {
            var orders = _getAllOrdersTask.Get().ToList();

            var customersIds = orders.Select(o => o.CustomerId).ToList();
            var customers = _getCustomersFLnameByIdsTask.Get(customersIds).ToList();

            orders.ForEach(o =>
            {
                var customer = customers.Where(c => c.Id == o.CustomerId).First();
                o.FirstName = customer.FirstName;
                o.LastName = customer.LastName;

                var productsIds = o.ProductOrders.Select(o => o.ProductId).ToList();
                var products = _getProductsByIdsTask.Get(productsIds);

                o.ProductOrders.ToList().ForEach(productOrder =>
                {
                    productOrder.ProductDescription = products.Where(p => p.Id == productOrder.ProductId).Select(p => p.Description).First();
                });

            });

            return orders;
        }
    }
}

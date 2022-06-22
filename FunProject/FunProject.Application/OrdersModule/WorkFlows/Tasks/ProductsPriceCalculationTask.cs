using FunProject.Application.Data.Products.Query;
using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using System.Linq;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class ProductsPriceCalculationTask : IProductsPriceCalculationTask
    {
        private readonly IGetProductPriceQuery _getProductPriceQuery;
        public ProductsPriceCalculationTask(IGetProductPriceQuery getProductPriceQuery)
        {
            _getProductPriceQuery = getProductPriceQuery;
        }

        public float Calculate(OrderDto order)
        {
            return order.ProductOrders.ToList().Sum(productOrder =>
                _getProductPriceQuery.Get(productOrder.ProductId) * productOrder.Quantity);
        }
    }
}

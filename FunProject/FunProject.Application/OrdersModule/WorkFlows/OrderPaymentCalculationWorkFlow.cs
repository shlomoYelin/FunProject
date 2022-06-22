using FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.Factorys.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;

namespace FunProject.Application.OrdersModule.WorkFlows
{
    public class OrderPaymentCalculationWorkFlow : IOrderPaymentCalculationWorkFlow
    {
        private readonly IProductsPriceCalculationTask _productsPriceCalculationTask;
        private readonly IGetCustomerTypeTask _getCustomerTypeTask;
        private readonly IUserDiscountPercentageFactory _userDiscountPercentageFactory;
        private readonly IGetOrderPaymentByDiscountPercentageTask _getOrderPaymentByDiscountPercentageTask;

        public OrderPaymentCalculationWorkFlow(
            IProductsPriceCalculationTask productsPriceCalculationTask,
            IGetCustomerTypeTask getCustomerTypeTask,
            IUserDiscountPercentageFactory userDiscountPercentageFactory,
            IGetOrderPaymentByDiscountPercentageTask getOrderPaymentByDiscountPercentageTask
            )
        {
            _productsPriceCalculationTask = productsPriceCalculationTask;
            _getCustomerTypeTask = getCustomerTypeTask;
            _userDiscountPercentageFactory = userDiscountPercentageFactory;
            _getOrderPaymentByDiscountPercentageTask = getOrderPaymentByDiscountPercentageTask;
        }
        public float Calculate(OrderDto order)
        {
            var payment = _productsPriceCalculationTask.Calculate(order);

            var userType = _getCustomerTypeTask.Get(order.CustomerId);

            var DiscountPercentage = _userDiscountPercentageFactory.Get(userType).GetDiscountPercentage();

            return _getOrderPaymentByDiscountPercentageTask.Calculate(DiscountPercentage, payment);
        }
    }
}

using FunProject.Application.Data.Orders.Query;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class OrderIsExistsByCustomerIdTask : IOrderIsExistsByCustomerIdTask
    {
        private readonly IOrderIsExistsByCustomerIdQuery _orderIsExistsByCustomerIdQuery;

        public OrderIsExistsByCustomerIdTask(IOrderIsExistsByCustomerIdQuery orderIsExistsByCustomerIdQuery)
        {
            _orderIsExistsByCustomerIdQuery = orderIsExistsByCustomerIdQuery;
        }

        public bool IsExists(int customerId)
        {
            return _orderIsExistsByCustomerIdQuery.IsExists(customerId);
        }
    }
}

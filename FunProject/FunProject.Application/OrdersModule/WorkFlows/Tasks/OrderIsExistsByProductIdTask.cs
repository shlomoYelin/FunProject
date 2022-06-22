using FunProject.Application.Data.Orders.Query;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class OrderIsExistsByProductIdTask : IOrderIsExistsByProductIdTask
    {
        private readonly IOrderIsExistsByProductIdQuery _orderIsExistsByProductIdQuery;

        public OrderIsExistsByProductIdTask(IOrderIsExistsByProductIdQuery orderIsExistsByProductIdQuery)
        {
            _orderIsExistsByProductIdQuery = orderIsExistsByProductIdQuery;
        }
        public bool IsExists(int productId)
        {
            return _orderIsExistsByProductIdQuery.IsExists(productId);
        }
    }
}

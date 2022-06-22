using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class GetOrderPaymentByDiscountPercentageTask : IGetOrderPaymentByDiscountPercentageTask
    {
        public float Calculate(float discountPercentage, float payment)
        {
            return payment - (discountPercentage / 100 * payment);
        }
    }
}

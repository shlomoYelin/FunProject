namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IGetOrderPaymentByDiscountPercentageTask
    {
        float Calculate(float DiscountPercentage, float Payment);
    }
}

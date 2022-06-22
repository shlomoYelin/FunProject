namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IOrderIsExistsByCustomerIdTask
    {
        bool IsExists(int customerId);
    }
}

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IOrderIsExistsByProductIdTask
    {
        bool IsExists(int productId);
    }
}

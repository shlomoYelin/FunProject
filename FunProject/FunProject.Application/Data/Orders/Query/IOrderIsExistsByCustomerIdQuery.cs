namespace FunProject.Application.Data.Orders.Query
{
    public interface IOrderIsExistsByCustomerIdQuery
    {
        bool IsExists(int customerId);
    }
}

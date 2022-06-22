namespace FunProject.Application.Data.Orders.Query
{
    public interface IOrderIsExistsByProductIdQuery
    {
        bool IsExists(int productId);
    }
}

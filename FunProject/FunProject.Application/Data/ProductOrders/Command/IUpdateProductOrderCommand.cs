using FunProject.Domain.Entities;

namespace FunProject.Application.Data.ProductOrders.Command
{
    public interface IUpdateProductOrderCommand
    {
        void Update(ProductOrder productOrder);
    }
}

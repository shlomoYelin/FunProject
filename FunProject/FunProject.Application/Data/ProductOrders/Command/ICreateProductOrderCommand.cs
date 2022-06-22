using FunProject.Domain.Entities;

namespace FunProject.Application.Data.ProductOrders.Command
{
    public interface ICreateProductOrderCommand
    {
        void Create(ProductOrder productOrder);
    }
}

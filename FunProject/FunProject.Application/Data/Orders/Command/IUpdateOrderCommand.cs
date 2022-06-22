using FunProject.Domain.Entities;

namespace FunProject.Application.Data.Orders.Command
{
    public interface IUpdateOrderCommand
    {
        void Update(Order order);
    }
}

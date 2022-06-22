using FunProject.Domain.Entities;

namespace FunProject.Application.Data.Orders.Command
{
    public interface IDeleteOrderCommand
    {
        void Delete(Order order);
    }
}

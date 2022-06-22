using FunProject.Domain.Entities;

namespace FunProject.Application.Data.Orders.Command
{
    public interface ICreateOrderCommand
    {
        void Create(Order order);
    }
}

using FunProject.Domain.Entities;

namespace FunProject.Application.Data.Orders.Query
{
    public interface IOrderByIdQuery
    {
        Order Get(int id);
    }
}

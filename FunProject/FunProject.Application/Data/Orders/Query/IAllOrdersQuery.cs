using FunProject.Domain.Entities;
using System.Collections.Generic;

namespace FunProject.Application.Data.Orders.Query
{
    public interface IAllOrdersQuery
    {
        IList<Order> Get();
    }
}

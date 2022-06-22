using FunProject.Domain.Entities;
using System.Collections.Generic;

namespace FunProject.Application.Data.ProductOrders.Query
{
    public interface IProductOrdersByOrderIdQuery
    {
        IList<ProductOrder> Get(int orderId);
    }
}

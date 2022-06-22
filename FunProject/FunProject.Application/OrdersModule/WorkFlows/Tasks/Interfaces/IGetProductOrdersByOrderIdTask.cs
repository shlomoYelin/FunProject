using FunProject.Domain.Entities;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IGetProductOrdersByOrderIdTask
    {
        IList<ProductOrder> Get(int orderId);
    }
}

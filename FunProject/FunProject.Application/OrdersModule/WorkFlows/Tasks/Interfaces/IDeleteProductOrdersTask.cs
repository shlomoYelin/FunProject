using FunProject.Domain.Entities;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IDeleteProductOrdersTask
    {
        void Delete(IList<ProductOrder> productOrders);
    }
}

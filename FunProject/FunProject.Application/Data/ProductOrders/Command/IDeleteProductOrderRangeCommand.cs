using FunProject.Domain.Entities;
using System.Collections.Generic;

namespace FunProject.Application.Data.ProductOrders.Command
{
    public interface IDeleteProductOrderRangeCommand
    {
        void Delete(IList<ProductOrder> productOrders);
    }
}

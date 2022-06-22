using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.ProductOrderModule.Dtos;
using FunProject.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class GetProductOrdersToDeleteTask : IGetProductOrdersToDeleteTask
    {
        public IList<ProductOrder> Get(IList<ProductOrder> dbProductOrders, IList<ProductOrderDto> clientProductOrders)
        {
            return dbProductOrders
                .Where(dbProductOrder =>
                !clientProductOrders.Any(clinetProductOrder => clinetProductOrder.ProductId == dbProductOrder.ProductId))
                .ToList();
        }
    }
}

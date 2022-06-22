using FunProject.Application.ProductOrderModule.Dtos;
using FunProject.Domain.Entities;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IGetProductOrdersToDeleteTask
    {
        IList<ProductOrder> Get(IList<ProductOrder> dbProductOrders, IList<ProductOrderDto> clientProductOrders);
    }
}

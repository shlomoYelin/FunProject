using FunProject.Application.OrdersModule.Dtos;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.WorkFlows.Interfaces
{
    public interface IGetAllOrdersWorkFlow
    {
        IList<OrderDto> Get();
    }
}

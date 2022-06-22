using FunProject.Application.OrdersModule.Dtos;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IGetAllOrdersTask
    {
        IList<OrderDto> Get();
    }
}

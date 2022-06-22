using FunProject.Application.OrdersModule.Dtos;
using FunProject.Domain.Models;

namespace FunProject.Application.OrdersModule.WorkFlows.Interfaces
{
    public interface IUpdateOrderWorkFlow
    {
        ActionStatusModel Update(OrderDto order);
    }
}

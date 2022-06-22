using FunProject.Application.OrdersModule.Dtos;
using FunProject.Domain.Models;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface ICreateOrderTask
    {
        ActionStatusModel Create(OrderDto order);
    }
}

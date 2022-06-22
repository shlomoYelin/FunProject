using FunProject.Application.OrdersModule.Dtos;
using FunProject.Domain.Models;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.Services.Interfaces
{
    public interface IOrdersService
    {
        IList<OrderDto> GetAllOrders();
        OrderDto GetOrder(int id);  
        ActionStatusModel CreateOrder(OrderDto order);
        ActionStatusModel UpdateOrder(OrderDto order);
        ActionStatusModel DeleteOrder(int id);
    }
}
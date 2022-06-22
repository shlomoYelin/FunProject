using FunProject.Application.OrdersModule.Dtos;
using FunProject.Domain.Models;

namespace FunProject.Application.OrdersModule.Validators.Interfaces
{
    public interface IUpdateOrderValidator
    {
        ActionStatusModel Validation(OrderDto order);
    }
}

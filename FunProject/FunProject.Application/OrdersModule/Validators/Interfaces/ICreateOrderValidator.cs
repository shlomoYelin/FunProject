using FunProject.Application.OrdersModule.Dtos;
using FunProject.Domain.Models;

namespace FunProject.Application.OrdersModule.Validators.Interfaces
{
    public interface ICreateOrderValidator
    {
        ActionStatusModel Validation(OrderDto order);
    }
}

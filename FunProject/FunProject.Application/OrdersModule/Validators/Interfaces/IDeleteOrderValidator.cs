using FunProject.Domain.Models;

namespace FunProject.Application.OrdersModule.Validators.Interfaces
{
    public interface IDeleteOrderValidator
    {
        ActionStatusModel Validate(int orderId);
    }
}

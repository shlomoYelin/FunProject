using FunProject.Domain.Models;

namespace FunProject.Application.OrdersModule.Validators.Interfaces
{
    public interface IGetOrderValidator
    {
        ActionStatusModel Validate(int orderId);
    }
}

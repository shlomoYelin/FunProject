using FunProject.Domain.Models;

namespace FunProject.Application.CustomersModule.Validators.Interfaces
{
    public interface IDeleteCustomerValidator
    {
        ActionStatusModel Validate(int customerId);
    }
}

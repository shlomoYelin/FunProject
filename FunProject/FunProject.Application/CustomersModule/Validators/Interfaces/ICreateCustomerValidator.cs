using FunProject.Application.CustomersModule.Dtos;
using FunProject.Domain.Models;

namespace FunProject.Application.CustomersModule.Validators.Interfaces
{
    public interface ICreateCustomerValidator
    {
        ActionStatusModel Validate(CustomerDto customer);
    }
}

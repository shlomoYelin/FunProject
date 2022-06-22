using FunProject.Application.CustomersModule.Dtos;
using FunProject.Domain.Models;

namespace FunProject.Application.CustomersModule.Validators.Interfaces
{
    public interface IUpdateCustomerValidator
    {
        ActionStatusModel Validate(CustomerDto customer);
    }
}

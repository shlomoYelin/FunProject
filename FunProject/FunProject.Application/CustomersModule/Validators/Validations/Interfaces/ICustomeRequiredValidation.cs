using FunProject.Application.CustomersModule.Dtos;

namespace FunProject.Application.CustomersModule.Validators.Validations.Interfaces
{
    public interface ICustomeRequiredValidation
    {
        void Validate(CustomerDto customer);
    }
}

using FunProject.Application.CustomersModule.Dtos;
using FunProject.Application.CustomersModule.Validators.Interfaces;
using FunProject.Application.CustomersModule.Validators.Validations.Interfaces;
using FunProject.Domain.Models;

namespace FunProject.Application.CustomersModule.Validators
{
    public class CreateCustomerValidator : ICreateCustomerValidator
    {
        private readonly ICustomeRequiredValidation _customeRequiredValidation;

        public CreateCustomerValidator(ICustomeRequiredValidation customeRequiredValidation)
        {
            _customeRequiredValidation = customeRequiredValidation;
        }
        public ActionStatusModel Validate(CustomerDto customer)
        {
            ActionStatusModel actionStatus = new();
            try
            {
                _customeRequiredValidation.Validate(customer);
                actionStatus.Success = true;
            }
            catch (System.Exception ex)
            {
                actionStatus.Success = false;
                actionStatus.Message = ex.Message;
                return actionStatus;
            }

            return actionStatus;
        }
    }
}

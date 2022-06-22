using FunProject.Application.CustomersModule.Dtos;
using FunProject.Application.CustomersModule.Validators.Interfaces;
using FunProject.Application.CustomersModule.Validators.Validations.Interfaces;
using FunProject.Domain.Models;

namespace FunProject.Application.CustomersModule.Validators
{
    public class UpdateCustomerValidator : IUpdateCustomerValidator
    {
        private readonly ICustomerIsExistsValidation _customerIsExistsValidation;
        private readonly ICustomeRequiredValidation _customeRequiredValidation;

        public UpdateCustomerValidator(
            ICustomerIsExistsValidation customerIsExistsValidation,
            ICustomeRequiredValidation customeRequiredValidation)
        {
            _customerIsExistsValidation = customerIsExistsValidation;
            _customeRequiredValidation = customeRequiredValidation;
        }
        public ActionStatusModel Validate(CustomerDto customer)
        {
            ActionStatusModel actionStatus = new();
            try
            {
                _customerIsExistsValidation.Validate(customer.Id);
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

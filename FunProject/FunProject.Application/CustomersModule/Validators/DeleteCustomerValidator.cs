using FunProject.Application.CustomersModule.Validators.Interfaces;
using FunProject.Application.CustomersModule.Validators.Validations.Interfaces;
using FunProject.Domain.Models;
using System;

namespace FunProject.Application.CustomersModule.Validators
{
    public class DeleteCustomerValidator : IDeleteCustomerValidator
    {
        private readonly ICustomerIsExistsValidation _customerIsExistsValidation;

        public DeleteCustomerValidator(ICustomerIsExistsValidation customerIsExistsValidation)
        {
            _customerIsExistsValidation = customerIsExistsValidation;
        }
        public ActionStatusModel Validate(int customerId)
        {
            ActionStatusModel actionStatusModel = new();  
            try
            {
                _customerIsExistsValidation.Validate(customerId);
                actionStatusModel.Success = true;
            }
            catch (Exception ex)
            {
                actionStatusModel.Success = false;
                actionStatusModel.Message = ex.Message;
            }

            return actionStatusModel;
        }
    }
}

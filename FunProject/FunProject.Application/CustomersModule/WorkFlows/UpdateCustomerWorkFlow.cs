using FunProject.Application.CustomersModule.Dtos;
using FunProject.Domain.Models;
using FunProject.Application.CustomersModule.WorkFlows.Interfaces;
using FunProject.Application.CustomersModule.Validators.Interfaces;
using FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces;

namespace FunProject.Application.CustomersModule.WorkFlows
{
    public class UpdateCustomerWorkFlow : IUpdateCustomerWorkFlow
    {
        private readonly IUpdateCustomerTask _UpdateCustomerTask;
        private readonly IUpdateCustomerValidator _updateCustomerValidateTask;

        public UpdateCustomerWorkFlow(IUpdateCustomerTask UpdateCustomerTask, IUpdateCustomerValidator updateCustomerValidateTask)
        {
            _UpdateCustomerTask = UpdateCustomerTask;
            _updateCustomerValidateTask = updateCustomerValidateTask;
        }

        public ActionStatusModel Update(CustomerDto customer)
        {
            var ValidationResult = _updateCustomerValidateTask.Validate(customer);
            if(!ValidationResult.Success)
            {
                return ValidationResult;
            }
            return _UpdateCustomerTask.Update(customer);
        }
    }
}

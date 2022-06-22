using FunProject.Application.CustomersModule.Dtos;
using FunProject.Application.CustomersModule.Validators.Interfaces;
using FunProject.Application.CustomersModule.WorkFlows.Interfaces;
using FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Models;

namespace FunProject.Application.CustomersModule.WorkFlows
{
    public class CreateCustomerWorkFlow : ICreateCustomerWorkFlow
    {
        private readonly ICreateCustomerTask _CreateCustomerTask;
        private readonly ICreateCustomerValidator _createCustomerValidator1;


        public CreateCustomerWorkFlow(ICreateCustomerTask CreateCustomerTask, ICreateCustomerValidator createCustomerValidator)
        {
            _CreateCustomerTask = CreateCustomerTask;
            _createCustomerValidator1 = createCustomerValidator;
        }

        public ActionStatusModel Create(CustomerDto customer)
        {
            customer.Id = 0;
            var ValidationResult = _createCustomerValidator1.Validate(customer);
            if(!ValidationResult.Success)
            {
                return ValidationResult;
            }
            return _CreateCustomerTask.Create(customer);
        }
    }
}

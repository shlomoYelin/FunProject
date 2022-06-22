using FunProject.Application.CustomersModule.Validators.Validations.Interfaces;
using FunProject.Application.Data.Customers.Query;

namespace FunProject.Application.CustomersModule.Validators.Validations
{
    public class CustomerIsExistsValidation : ICustomerIsExistsValidation
    {
        private readonly ICustomerIsExistsQuery _customerIsExistsQuery;

        public CustomerIsExistsValidation(ICustomerIsExistsQuery customerIsExistsQuery)
        {
            _customerIsExistsQuery = customerIsExistsQuery;
        }
        public void Validate(int customerId)
        {
            if (!_customerIsExistsQuery.IsExists(customerId))
            {
                throw new System.Exception("Customer not found");
            }
        }
    }
}

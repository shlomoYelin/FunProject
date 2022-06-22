using FunProject.Application.CustomersModule.Dtos;
using FunProject.Application.CustomersModule.Validators.Validations.Interfaces;

namespace FunProject.Application.CustomersModule.Validators.Validations
{
    public class CustomeRequiredValidation : ICustomeRequiredValidation
    {
        public void Validate(CustomerDto customer)
        {
            string ErrorMessage = "";

            if(customer.FirstName == null || customer.FirstName == "") 
            {
                ErrorMessage = "First name is required.";
            }

            if (customer.LastName == null || customer.LastName == "")
            {
                ErrorMessage += " Last name is required";
            }

            if ((int)customer.Type < 1)
            {
                ErrorMessage += " Type name is required";
            }

            if(ErrorMessage.Length > 0)
            {
                throw new System.Exception(ErrorMessage);
            }
        }
    }
}

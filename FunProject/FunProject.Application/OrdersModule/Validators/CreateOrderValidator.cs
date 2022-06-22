using FunProject.Application.OrdersModule.Dtos;
using FunProject.Domain.Models;
using FunProject.Application.OrdersModule.Validators.Interfaces;
using FunProject.Application.CustomersModule.Validators.Validations.Interfaces;
using FunProject.Application.ProductsModule.Validators.Validations.Interfaces;

namespace FunProject.Application.OrdersModule.Validators
{
    public class CreateOrderValidator : ICreateOrderValidator
    {
        private readonly ICustomerIsExistsValidation _customerIsExistsValidation;
        private readonly IProductsIsExistsValidation _productsIsExistsValidation;

        public CreateOrderValidator(ICustomerIsExistsValidation customerIsExistsValidation,
            IProductsIsExistsValidation productsIsExistsValidation)
        {
            _customerIsExistsValidation = customerIsExistsValidation;
            _productsIsExistsValidation = productsIsExistsValidation;
        }
        public ActionStatusModel Validation(OrderDto order)
        {
            ActionStatusModel actionStatus = new();
            try
            {
                _customerIsExistsValidation.Validate(order.CustomerId);

                _productsIsExistsValidation.Validate(order.ProductOrders);

                actionStatus.Success = true;
            }
            catch (System.Exception ex)
            {
                actionStatus.Success = false;
                actionStatus.Message = ex.Message;
            }

            return actionStatus;
        }
    }
}

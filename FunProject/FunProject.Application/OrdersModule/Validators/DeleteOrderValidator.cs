using FunProject.Application.OrdersModule.Validators.Interfaces;
using FunProject.Application.OrdersModule.Validators.Validations.Interfaces;
using FunProject.Domain.Models;
using System;

namespace FunProject.Application.OrdersModule.Validators
{
    public class DeleteOrderValidator : IDeleteOrderValidator
    {
        private readonly IOrderIsExistsValidation _orderIsExistsValidation;

        public DeleteOrderValidator(IOrderIsExistsValidation orderIsExistsValidation)
        {
            _orderIsExistsValidation = orderIsExistsValidation;
        }
        public ActionStatusModel Validate(int orderId)
        {
            ActionStatusModel actionStatus = new();

            try
            {
                _orderIsExistsValidation.Validate(orderId);
                actionStatus.Success = true;
            }
            catch (Exception ex)
            {
                actionStatus.Success = false;
                actionStatus .Message = ex.Message;
            }

            return actionStatus;
        }
    }
}

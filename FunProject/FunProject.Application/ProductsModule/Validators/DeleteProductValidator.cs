using FunProject.Application.ProductsModule.Validators.Interfaces;
using FunProject.Application.ProductsModule.Validators.Validations.Interfaces;
using FunProject.Domain.Models;
using System;

namespace FunProject.Application.ProductsModule.Validators
{
    public class DeleteProductValidator : IDeleteProductValidator
    {
        private readonly IProductIsExistsValidation _productIsExistsValidation;

        public DeleteProductValidator(IProductIsExistsValidation productIsExistsValidation)
        {
            _productIsExistsValidation = productIsExistsValidation;
        }
        public ActionStatusModel Validate(int productId)
        {
            ActionStatusModel actionStatusModel = new();

            try
            {
                _productIsExistsValidation.Validate(productId);
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

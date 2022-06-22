using FunProject.Application.ProductsModule.Dtos;
using FunProject.Application.ProductsModule.Validators.Interfaces;
using FunProject.Application.ProductsModule.Validators.Validations.Interfaces;
using FunProject.Domain.Models;

namespace FunProject.Application.ProductsModule.Validators
{
    public class UpdateProductValidator : IUpdateProductValidator
    {
        private readonly IProductIsExistsValidation _productIsExistsValidation;
        private readonly IProductRequierdValidation _productRequierdValidation;

        public UpdateProductValidator(IProductIsExistsValidation productIsExistsValidation, IProductRequierdValidation productRequierdValidation)
        {
            _productIsExistsValidation = productIsExistsValidation;   
            _productRequierdValidation = productRequierdValidation;
        }
        public ActionStatusModel Validate(ProductDto product)
        {
            ActionStatusModel actionStatusModel = new();

            try
            {
                _productIsExistsValidation.Validate(product.Id);
                _productRequierdValidation.Validate(product);
                actionStatusModel.Success = true;
            }
            catch (System.Exception ex)
            {
                actionStatusModel.Success = false;
                actionStatusModel.Message = ex.Message;
            }

            return actionStatusModel;
        }
    }
}

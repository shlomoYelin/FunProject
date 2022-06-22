using FunProject.Application.ProductsModule.Dtos;
using FunProject.Application.ProductsModule.Validators.Interfaces;
using FunProject.Application.ProductsModule.Validators.Validations.Interfaces;
using FunProject.Domain.Models;

namespace FunProject.Application.ProductsModule.Validators
{
    public class CreateProductValidator : ICreateProductValidator
    {
        private readonly IProductRequierdValidation _productRequierdValidation;

        public CreateProductValidator(IProductRequierdValidation productRequierdValidation)
        {
            _productRequierdValidation = productRequierdValidation;
        }
        public ActionStatusModel Validate(ProductDto product)
        {
            ActionStatusModel actionStatusModel = new();

            try
            {
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

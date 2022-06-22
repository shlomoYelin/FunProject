using FunProject.Application.ProductsModule.Dtos;

namespace FunProject.Application.ProductsModule.Validators.Validations.Interfaces
{
    public interface IProductRequierdValidation
    {
        void Validate(ProductDto product);
    }
}

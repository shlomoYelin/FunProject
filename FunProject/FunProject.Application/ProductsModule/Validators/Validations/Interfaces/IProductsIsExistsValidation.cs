using FunProject.Application.ProductOrderModule.Dtos;
using System.Collections.Generic;

namespace FunProject.Application.ProductsModule.Validators.Validations.Interfaces
{
    public interface IProductsIsExistsValidation
    {
        void Validate(IList<ProductOrderDto> Ids);
    }
}

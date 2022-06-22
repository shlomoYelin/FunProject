using FunProject.Application.Data.Products.Query;
using FunProject.Application.ProductOrderModule.Dtos;
using FunProject.Application.ProductsModule.Validators.Validations.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Application.ProductsModule.Validators.Validations
{
    public class ProductsIsExistsValidation : IProductsIsExistsValidation
    {
        private readonly IProductIsExistsQuery _productIsExistsQuery;
        public ProductsIsExistsValidation(IProductIsExistsQuery productIsExistsQuery)
        {
            _productIsExistsQuery = productIsExistsQuery;
        }

        public void Validate(IList<ProductOrderDto> products)
        {
            products.ToList().ForEach(product =>
            {
                if (!_productIsExistsQuery.IsExists(product.ProductId))
                {
                    throw new System.Exception($"{product.ProductDescription} not found");
                }
            });
        }
    }
}




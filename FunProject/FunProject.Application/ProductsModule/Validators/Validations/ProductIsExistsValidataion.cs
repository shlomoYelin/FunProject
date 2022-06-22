using FunProject.Application.Data.Products.Query;
using FunProject.Application.ProductsModule.Validators.Validations.Interfaces;

namespace FunProject.Application.ProductsModule.Validators.Validations
{
    public class ProductIsExistsValidataion : IProductIsExistsValidation
    {
        private readonly IProductIsExistsQuery _productIsExistsQuery;

        public ProductIsExistsValidataion(IProductIsExistsQuery productIsExistsQuery)
        {
            _productIsExistsQuery = productIsExistsQuery;
        }
        public void Validate(int productId)
        {
            if(!_productIsExistsQuery.IsExists(productId))
            {
                throw new System.Exception("Product not found");
            }
        }
    }
}

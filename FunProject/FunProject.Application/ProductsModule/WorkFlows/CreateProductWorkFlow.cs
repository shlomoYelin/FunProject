using FunProject.Application.ProductsModule.Dtos;
using FunProject.Application.ProductsModule.Validators.Interfaces;
using FunProject.Application.ProductsModule.WorkFlows.Interfaces;
using FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Models;

namespace FunProject.Application.ProductsModule.WorkFlows
{
    public class CreateProductWorkFlow : ICreateProductWorkFlow
    {
        private readonly ICreateProductTask _createProductTask;
        private readonly ICreateProductValidator _createProductValidateTask;

        public CreateProductWorkFlow(ICreateProductTask createProductTask, ICreateProductValidator createProductValidateTask)
        {
            _createProductTask = createProductTask;
            _createProductValidateTask = createProductValidateTask;
        }

        public ActionStatusModel Create(ProductDto product)
        {
            product.Id = 0;

            var validationResult = _createProductValidateTask.Validate(product);
            if (validationResult.Success == false)
            {
                return validationResult;
            }

            return _createProductTask.Create(product);
        }
    }
}

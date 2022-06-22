using FunProject.Application.ProductsModule.Dtos;
using FunProject.Application.ProductsModule.Validators.Interfaces;
using FunProject.Application.ProductsModule.WorkFlows.Interfaces;
using FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Models;

namespace FunProject.Application.ProductsModule.WorkFlows
{
    public class UpdateProductWorkFlow : IUpdateProductWorkFlow
    {
        private readonly IUpdateProductTask _UpdateCustomerTask;
        private readonly IUpdateProductValidator _updateProductValidateTask;

        public UpdateProductWorkFlow(IUpdateProductTask updateProductTask, IUpdateProductValidator updateProductValidateTask)
        {
            _UpdateCustomerTask = updateProductTask;
            _updateProductValidateTask = updateProductValidateTask;
        }

        public ActionStatusModel Update(ProductDto product)
        {
            var validationResult = _updateProductValidateTask.Validate(product);

            if (validationResult.Success == false)
            {
                return validationResult;
            }

            return _UpdateCustomerTask.Update(product);
        }
    }
}

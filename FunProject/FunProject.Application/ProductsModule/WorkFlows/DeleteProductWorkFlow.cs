using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.ProductsModule.Validators.Interfaces;
using FunProject.Application.ProductsModule.WorkFlows.Interfaces;
using FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Models;

namespace FunProject.Application.ProductsModule.WorkFlows
{
    public class DeleteProductWorkFlow : IDeleteProductWorkFlow
    {
        private readonly IDeleteProductTask _deleteCustomerTask;
        private readonly IDeleteProductValidator _deleteProductValidator;
        private readonly IOrderIsExistsByProductIdTask _orderIsExistsByProductIdTask;

        public DeleteProductWorkFlow(IDeleteProductTask deleteCustomerTask,
            IDeleteProductValidator deleteProductValidator,
            IOrderIsExistsByProductIdTask orderIsExistsByProductIdTask)
        {
            _deleteCustomerTask = deleteCustomerTask;
            _deleteProductValidator = deleteProductValidator;
            _orderIsExistsByProductIdTask = orderIsExistsByProductIdTask;
        }
        public ActionStatusModel Delete(int id)
        {
            var actionStatus = _deleteProductValidator.Validate(id);
            if (!actionStatus.Success)
            {
                return actionStatus;
            }

            if (_orderIsExistsByProductIdTask.IsExists(id))
            {
                actionStatus.Success = false;
                actionStatus.Message = "Can't delete the product, because he has an existing order";
                return actionStatus;
            }

            return _deleteCustomerTask.Delete(new Domain.Entities.Product { Id = id });
        }
    }
}

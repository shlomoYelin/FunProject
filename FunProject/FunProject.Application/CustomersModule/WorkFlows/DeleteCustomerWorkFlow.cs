using FunProject.Application.CustomersModule.Validators.Interfaces;
using FunProject.Application.CustomersModule.WorkFlows.Interfaces;
using FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Models;

namespace FunProject.Application.CustomersModule.WorkFlows
{
    public class DeleteCustomerWorkFlow : IDeleteCustomerWorkFlow
    {
        private readonly IDeleteCustomerTask _deleteCustomerTask;
        private readonly IDeleteCustomerValidator _deleteCustomerValidator;
        private readonly IOrderIsExistsByCustomerIdTask _orderIsExistsByCustomerIdTask;

        public DeleteCustomerWorkFlow(IDeleteCustomerTask deleteCustomerTask,
            IDeleteCustomerValidator deleteCustomerValidator,
            IOrderIsExistsByCustomerIdTask orderIsExistsByCustomerIdTask)
        {
            _deleteCustomerTask = deleteCustomerTask;
            _deleteCustomerValidator = deleteCustomerValidator;
            _orderIsExistsByCustomerIdTask = orderIsExistsByCustomerIdTask;
        }
        public ActionStatusModel Delete(int id)
        {
            var actionStatus = _deleteCustomerValidator.Validate(id);
            if (!actionStatus.Success)
            {
                return actionStatus;
            }

            if (_orderIsExistsByCustomerIdTask.IsExists(id))
            {
                actionStatus.Success = false;
                actionStatus.Message = "Can't delete the customer, because he has an existing order";
                return actionStatus;
            }

            return _deleteCustomerTask.Delete(new Domain.Entities.Customer { Id = id });
        }
    }
}

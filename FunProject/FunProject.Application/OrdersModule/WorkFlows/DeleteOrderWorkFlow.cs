using FunProject.Application.OrdersModule.Validators.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Models;

namespace FunProject.Application.OrdersModule.WorkFlows
{
    public class DeleteOrderWorkFlow : IDeleteOrderWorkFlow
    {
        private readonly IDeleteOrderTask _deleteOrderTask;
        private readonly IDeleteOrderValidator _deleteOrderValidator;

        public DeleteOrderWorkFlow(IDeleteOrderTask deleteOrderTask, 
            IDeleteOrderValidator deleteOrderValidator)
        {
            _deleteOrderTask = deleteOrderTask;
            _deleteOrderValidator = deleteOrderValidator;
        }
        public ActionStatusModel Delete(int id)
        {
            var validationResult = _deleteOrderValidator.Validate(id);
            if(!validationResult.Success)
            {
                return validationResult;
            }
            return _deleteOrderTask.Delete(new Domain.Entities.Order { Id = id});
        }
    }
}

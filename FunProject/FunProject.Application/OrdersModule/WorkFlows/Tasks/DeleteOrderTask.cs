using FunProject.Application.Data.Orders.Command;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Entities;
using FunProject.Domain.Logger;
using FunProject.Domain.Models;
using System;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class DeleteOrderTask : IDeleteOrderTask
    {

        private readonly ILoggerAdapter<DeleteOrderTask> _logger;

        private readonly IDeleteOrderCommand _deleteOrderCommand;

        public DeleteOrderTask(
            ILoggerAdapter<DeleteOrderTask> loggerAdapter,
            IDeleteOrderCommand deleteOrderCommand)
        {
            _logger = loggerAdapter;
            _deleteOrderCommand = deleteOrderCommand;
        }


        public ActionStatusModel Delete(Order order)
        {
            _logger.LogInformation("Method DeleteOrder Invoked.");
            try
            {
                _deleteOrderCommand.Delete(order);
                return new ActionStatusModel() { Success = true, Message = "" };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Method DeleteOrder failed.");
                return new ActionStatusModel() { Success = false, Message = "Order delete failed ." };
            }
        }
    }
}

using FunProject.Application.Data.Customers.Command;
using FunProject.Domain.Logger;
using FunProject.Domain.Mapper;
using FunProject.Domain.Models;
using System;
using FunProject.Domain.Entities;
using FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces;

namespace FunProject.Application.CustomersModule.WorkFlows.Tasks
{
    public class DeleteCustomerTask : IDeleteCustomerTask
    {

        private readonly ILoggerAdapter<DeleteCustomerTask> _logger;
        private readonly IMapperAdapter _mapperAdapter;

        private readonly IDeleteCustomerCommand _deleteCustomerCommand;

        public DeleteCustomerTask(
            ILoggerAdapter<DeleteCustomerTask> loggerAdapter,
            IMapperAdapter mapperAdapter,
            IDeleteCustomerCommand deleteCustomerCommand)
        {
            _logger = loggerAdapter;
            _mapperAdapter = mapperAdapter;
            _deleteCustomerCommand = deleteCustomerCommand;
        }

        public ActionStatusModel Delete(Customer customer)
        {
            _logger.LogInformation("Method DeleteCustomer Invoked.");
            try
            {
                _deleteCustomerCommand.Delete(customer);
                return new ActionStatusModel() { Success = true, Message = "" };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Method DeleteCustomer failed.");
                return new ActionStatusModel() { Success = false, Message = "Customer delete failed ." };
            }
        }
    }
}

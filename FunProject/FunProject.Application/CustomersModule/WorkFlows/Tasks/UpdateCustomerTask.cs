using FunProject.Application.CustomersModule.Dtos;
using FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.Data.Customers.Command;
using FunProject.Domain.Entities;
using FunProject.Domain.Logger;
using FunProject.Domain.Mapper;
using FunProject.Domain.Models;
using System;

namespace FunProject.Application.CustomersModule.WorkFlows.Tasks
{
    public class UpdateCustomerTask : IUpdateCustomerTask
    {
        private readonly ILoggerAdapter<UpdateCustomerTask> _logger;
        private readonly IMapperAdapter _mapperAdapter;

        private readonly IUpdateCustomerCommand _updateCustomerCommand;
        public UpdateCustomerTask(
            ILoggerAdapter<UpdateCustomerTask> loggerAdapter,
            IMapperAdapter mapperAdapter,
            IUpdateCustomerCommand updateCustomerCommand)
        {
            _logger = loggerAdapter;
            _mapperAdapter = mapperAdapter;
            _updateCustomerCommand = updateCustomerCommand;
        }

        public ActionStatusModel Update(CustomerDto customer)
        {
            _logger.LogInformation("Method UpdateCustomer Invoked.");
            try
            {
                _updateCustomerCommand.Update(_mapperAdapter.Map<Customer>(customer));
                return new ActionStatusModel() { Success = true, Message = "" };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Method UpdateCustomer failed.");
                return new ActionStatusModel() { Success = false, Message = "Customer update fialed ." };
            }
        }
    }
}

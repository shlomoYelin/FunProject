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
    public class CreateCustomerTask : ICreateCustomerTask
    {
        private readonly ILoggerAdapter<CreateCustomerTask> _logger;
        private readonly IMapperAdapter _mapperAdapter;

        private readonly ICreateCustomerCommand _createCustomerCommand;
        public CreateCustomerTask(
            ILoggerAdapter<CreateCustomerTask> loggerAdapter,
            IMapperAdapter mapperAdapter,
            ICreateCustomerCommand createCustomerCommand)
        {
            _logger = loggerAdapter;
            _mapperAdapter = mapperAdapter;
            _createCustomerCommand = createCustomerCommand;
        }

        public ActionStatusModel Create(CustomerDto customer)
        {
            _logger.LogInformation("Method CreateCustomer Invoked.");
            try
            {
                _createCustomerCommand.Create(_mapperAdapter.Map<Customer>(customer));
                return new ActionStatusModel() { Success = true, Message = "" };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Method CreateCustomer failed.");
                return new ActionStatusModel() { Success = false, Message = "Customer creation failed ." };
            }
        }
    }
}

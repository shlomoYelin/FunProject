using FunProject.Application.OrdersModule.Dtos;
using FunProject.Domain.Entities;
using FunProject.Domain.Logger;
using FunProject.Domain.Mapper;
using FunProject.Domain.Models;
using System;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.Data.Orders.Command;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class CreateOrderTask : ICreateOrderTask
    {
        private readonly ILoggerAdapter<CreateOrderTask> _logger;
        private readonly IMapperAdapter _mapperAdapter;

        private readonly ICreateOrderCommand _createOrderCommand;
        public CreateOrderTask(
            ILoggerAdapter<CreateOrderTask> loggerAdapter,
            IMapperAdapter mapperAdapter,
            ICreateOrderCommand createOrderCommand)
        {
            _logger = loggerAdapter;
            _mapperAdapter = mapperAdapter;
            _createOrderCommand = createOrderCommand;
        }

        public ActionStatusModel Create(OrderDto order)
        {
            _logger.LogInformation("Method CreateOrder Invoked.");
            try
            {
                order.Id = 0;
                _createOrderCommand.Create(_mapperAdapter.Map<Order>(order));
                return new ActionStatusModel() { Success = true, Message = "" };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Method CreateOrder failed.");
                return new ActionStatusModel() { Success = false, Message = "Order creation failed " };
            }
        }
    }
}

using FunProject.Application.Data.Orders.Command;
using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Entities;
using FunProject.Domain.Mapper;
using System;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class UpdateOrderTask : IUpdateOrderTask
    {
        private readonly IUpdateOrderCommand _updateOrderCommand;
        private readonly IMapperAdapter _mapperAdapter;


        public UpdateOrderTask(IUpdateOrderCommand updateOrderCommand, IMapperAdapter mapperAdapter)
        {
            _updateOrderCommand = updateOrderCommand;
            _mapperAdapter = mapperAdapter;
        }
        public void Update(OrderDto order)
        {
            try
            {
                _updateOrderCommand.Update(_mapperAdapter.Map<Order>(order));
            }
            catch (Exception)
            {
                throw new Exception("Order Updated faild");
            }
        }
    }
}

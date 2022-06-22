using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.Services.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Interfaces;
using FunProject.Domain.Models;
using System.Collections.Generic;


namespace FunProject.Application.OrdersModule.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IGetAllOrdersWorkFlow _getAllOrdersWorkFlow;
        private readonly ICreateOrderWorkFlow _createOrderWorkFlow;
        private readonly IDeleteOrderWorkFlow _deleteOrderWorkFlow;
        private readonly IGetOrderByIdWorkFlow _getOrderByIdWorkFlow;
        private readonly IUpdateOrderWorkFlow _updateOrderWorkFlow;

        public OrdersService(
            IGetAllOrdersWorkFlow getAllOrdersWorkFlow,
            ICreateOrderWorkFlow createOrderWorkFlow,
            IDeleteOrderWorkFlow deleteOrderWorkFlow,
            IGetOrderByIdWorkFlow getOrderByIdWorkFlow,
            IUpdateOrderWorkFlow updateOrderWorkFlow)
        {
            _getAllOrdersWorkFlow = getAllOrdersWorkFlow;
            _createOrderWorkFlow = createOrderWorkFlow;
            _deleteOrderWorkFlow = deleteOrderWorkFlow;
            _getOrderByIdWorkFlow = getOrderByIdWorkFlow;
            _updateOrderWorkFlow = updateOrderWorkFlow;
        }

        public IList<OrderDto> GetAllOrders()
        {
            return _getAllOrdersWorkFlow.Get();
        }

        public ActionStatusModel CreateOrder(OrderDto order)
        {
            return _createOrderWorkFlow.Create(order);
        }

        public ActionStatusModel DeleteOrder(int id)
        {
            return _deleteOrderWorkFlow.Delete(id);
        }

        public OrderDto GetOrder(int id)
        {
            return _getOrderByIdWorkFlow.Get(id);
        }

        public ActionStatusModel UpdateOrder(OrderDto order)
        {
            return _updateOrderWorkFlow.Update(order);
        }
    }
}

using FunProject.Application.Data.Orders.Query;
using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Mapper;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class GetOrderByIdTask : IGetOrderByIdTask
    {
        private readonly IOrderByIdQuery _orderByIdQuery;
        private readonly IMapperAdapter _mapperAdapter;

        public GetOrderByIdTask(IOrderByIdQuery orderByIdQuery, IMapperAdapter mapperAdapter)
        {
            _orderByIdQuery = orderByIdQuery;
            _mapperAdapter = mapperAdapter;
        }

        public OrderDto Get(int id)
        {
            return _mapperAdapter.Map<OrderDto>(_orderByIdQuery.Get(id));
        }
    }
}

using FunProject.Application.OrdersModule.Dtos;
using FunProject.Domain.Logger;
using FunProject.Domain.Mapper;
using System;
using System.Collections.Generic;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.Data.Orders.Query;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class GetAllOrdersTask : IGetAllOrdersTask
    {
        private readonly IMapperAdapter _mapperAdapter;
        private readonly ILoggerAdapter<GetAllOrdersTask> _logger;

        private readonly IAllOrdersQuery _getAllOrdersQuery;
        public GetAllOrdersTask(
            ILoggerAdapter<GetAllOrdersTask> loggerAdapter,
            IMapperAdapter mapperAdapter,
            IAllOrdersQuery allOrdersQuery)
        {
            _logger = loggerAdapter;
            _mapperAdapter = mapperAdapter;
            _getAllOrdersQuery = allOrdersQuery;
        }

        public IList<OrderDto> Get()
        {
            _logger.LogInformation("Method GetAllOrders Invoked.");
            try
            {
                var result = _getAllOrdersQuery.Get();
                var mappedResult = _mapperAdapter.Map<IList<OrderDto>>(result);
                return mappedResult;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Method GetAllOrders failed.");
                throw;
            }
        }
    }
}

using FunProject.Application.CustomersModule.Dtos;
using FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.Data.Customers.Query;
using FunProject.Domain.Logger;
using FunProject.Domain.Mapper;
using System;
using System.Collections.Generic;

namespace FunProject.Application.CustomersModule.WorkFlows.Tasks
{
    public class GetAllCustomersTask : IGetAllCustomersTask
    {
        private readonly IMapperAdapter _mapperAdapter;
        private readonly ILoggerAdapter<GetAllCustomersTask> _logger;

        private readonly IAllCustomersQuery _getAllCustomersQuery;
        public GetAllCustomersTask(
            ILoggerAdapter<GetAllCustomersTask> loggerAdapter,
            IMapperAdapter mapperAdapter,
            IAllCustomersQuery allCustomersQuery)
        {
            _logger = loggerAdapter;
            _mapperAdapter = mapperAdapter;
            _getAllCustomersQuery = allCustomersQuery;
        }

        public IList<CustomerDto> Get()
        {
            _logger.LogInformation("Method GetAllCustomers Invoked.");
            try
            {
                var result = _getAllCustomersQuery.Get();
                var mappedResult = _mapperAdapter.Map<IList<CustomerDto>>(result.Result);
                return mappedResult;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Method GetAllCustomers failed.");
                throw;
            }
        }
    }
}

using FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.Data.Customers.Query;
using FunProject.Domain.Enums;
using FunProject.Domain.Mapper;

namespace FunProject.Application.CustomersModule.WorkFlows.Tasks
{
    public class GetCustomerTypeTask : IGetCustomerTypeTask
    {
        private readonly IGetCustomerTypeQuery _getCustomerTypeQuery;
        private readonly IMapperAdapter _mapperAdapter;

        public GetCustomerTypeTask(IGetCustomerTypeQuery getCustomerTypeQuery, IMapperAdapter mapperAdapter)
        {
            _getCustomerTypeQuery = getCustomerTypeQuery;
            _mapperAdapter = mapperAdapter;
        }
        public UserType Get(int customerId)
        {
            return _mapperAdapter.Map<UserType>(_getCustomerTypeQuery.Get(customerId));
        }
    }
}

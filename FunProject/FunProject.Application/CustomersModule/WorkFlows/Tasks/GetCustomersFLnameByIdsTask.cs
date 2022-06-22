using FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.Data.Customers.Query;
using System.Collections.Generic;

namespace FunProject.Application.CustomersModule.WorkFlows.Tasks
{
    public class GetCustomersFLnameByIdsTask : IGetCustomersFLnameByIdsTask
    {
        private readonly IGetCustomersFLnameByIdsQuery _getCustomersFLnameByIdsQuery;

        public GetCustomersFLnameByIdsTask(IGetCustomersFLnameByIdsQuery getCustomersFLnameByIdsQuery)
        {
            _getCustomersFLnameByIdsQuery = getCustomersFLnameByIdsQuery;
        }
        public IList<(int, string, string)> Get(IList<int> ids)
        {
            return _getCustomersFLnameByIdsQuery.Get(ids);
        }
    }
}

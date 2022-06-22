using System.Collections.Generic;

namespace FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces
{
    public interface IGetCustomersFLnameByIdsTask
    {
        IList<(int Id, string FirstName, string LastName)> Get(IList<int> ids);
    }
}

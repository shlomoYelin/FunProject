using System.Collections.Generic;

namespace FunProject.Application.Data.Customers.Query
{
    public interface IGetCustomersFLnameByIdsQuery
    {
        IList<(int Id, string FirstName, string LastName)> Get(IList<int> ids);
    }
}

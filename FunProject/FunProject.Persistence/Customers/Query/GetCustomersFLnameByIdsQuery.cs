using FunProject.Application.Data.Customers.Query;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Persistence.Customers.Query
{
    public class GetCustomersFLnameByIdsQuery : IGetCustomersFLnameByIdsQuery
    {
        private readonly AppDbContext _appDbContext;

        public GetCustomersFLnameByIdsQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IList<(int Id, string FirstName, string LastName)> Get(IList<int> ids)
        {
            return _appDbContext.Customers
                .Where(c => ids.Contains(c.Id))
                .Select(c =>  new System.ValueTuple<int, string, string>(  c.Id,  c.FirstName, c.LastName))
                .ToList();
        }
    }
}

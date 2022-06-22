using FunProject.Application.Data.Customers.Query;
using System.Linq;

namespace FunProject.Persistence.Customers.Query
{
    public class GetCustomerTypeQuery : IGetCustomerTypeQuery
    {
        private readonly AppDbContext _appDbContext;

        public GetCustomerTypeQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public int Get(int customerId)
        {
            return _appDbContext.Customers
                .Where(c => c.Id == customerId)
                .Select(c => c.Type)
                .First();
        }
    }
}

using FunProject.Application.Data.Customers.Query;
using System.Linq;

namespace FunProject.Persistence.Customers.Query
{
    public class CustomerIsExistsQuery : ICustomerIsExistsQuery
    {
        private readonly AppDbContext _appDbContext;

        public CustomerIsExistsQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public bool IsExists(int id)
        {
            return _appDbContext.Customers.Any(c => c.Id == id);
        }
    }
}

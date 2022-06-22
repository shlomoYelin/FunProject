using FunProject.Application.Data.Orders.Query;
using System.Linq;

namespace FunProject.Persistence.Orders.Query
{
    public class OrderIsExistsByCustomerIdQuery : IOrderIsExistsByCustomerIdQuery
    {
        private readonly AppDbContext _appDbContext;
        public OrderIsExistsByCustomerIdQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public bool IsExists(int customerId)
        {
            return _appDbContext.Orders.Any(o => o.CustomerId == customerId);
        }
    }
}

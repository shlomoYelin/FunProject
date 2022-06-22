using FunProject.Application.Data.Orders.Query;
using System.Linq;

namespace FunProject.Persistence.Orders.Query
{
    public class OrderIsExistsQuery : IOrderIsExistsQuery
    {
        private readonly AppDbContext _appDbContext;

        public OrderIsExistsQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public bool IsExists(int id)
        {
            return _appDbContext.Orders.Any(o => o.Id == id);
        }
    }
}

using FunProject.Application.Data.Orders.Query;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FunProject.Persistence.Orders.Query
{
    public class OrderIsExistsByProductIdQuery : IOrderIsExistsByProductIdQuery
    {
        private readonly AppDbContext _appDbContext;
        public OrderIsExistsByProductIdQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public bool IsExists(int productId)
        {
            return _appDbContext.Orders
                .Include(o => o.ProductOrders)
                .Any(o => o.ProductOrders
                .Any(productOrder => productOrder.ProductId == productId));
        }
    }
}

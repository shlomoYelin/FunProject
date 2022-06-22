using FunProject.Application.Data.ProductOrders.Query;
using FunProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Persistence.ProducOrders.Query
{
    public class ProductOrdersByOrderIdQuery : IProductOrdersByOrderIdQuery
    {
        private readonly AppDbContext _appDbContext;

        public ProductOrdersByOrderIdQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IList<ProductOrder> Get(int orderId)
        {
            return _appDbContext.ProductOrders.AsNoTracking().Where(o => o.OrderId == orderId).ToList();
        }
    }
}

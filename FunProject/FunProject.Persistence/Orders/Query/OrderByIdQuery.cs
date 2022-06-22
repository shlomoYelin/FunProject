using FunProject.Application.Data.Orders.Query;
using FunProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FunProject.Persistence.Orders.Query
{
    public class OrderByIdQuery : IOrderByIdQuery
    {
        private readonly AppDbContext _appDbContext;

        public OrderByIdQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Order Get(int id)
        {
            return _appDbContext.Orders.Include(o => o.ProductOrders).First(o => o.Id == id);
        }
    }
}

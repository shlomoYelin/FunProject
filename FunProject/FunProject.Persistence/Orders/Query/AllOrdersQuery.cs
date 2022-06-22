using FunProject.Application.Data.Orders.Query;
using FunProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Persistence.Orders.Query
{
    public class AllOrdersQuery : IAllOrdersQuery
    {
        private readonly AppDbContext _appDbContext;

        public AllOrdersQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IList<Order> Get()
        {
            return _appDbContext.Orders.Include(o => o.ProductOrders).ToList();
            //var orders =
            // _appDbContext.Orders
            //    .Include(o => o.Customer)
            //    .Include(o => o.ProductOrders).ThenInclude(po => po.Product)
            //    .Select(o => new Order()
            //    {
            //        Customer = new Customer() { FirstName = o.Customer.FirstName, LastName = o.Customer.LastName },
            //        Payment = o.Payment,
            //        Id = o.Id,
            //        CustomerId = o.CustomerId,
            //        Date = o.Date,
            //        ProductOrders = o.ProductOrders
            //    });

            //return orders.ToList();
        }
    }
}

using FunProject.Application.Data.ProductOrders.Command;
using FunProject.Domain.Entities;
using System.Collections.Generic;

namespace FunProject.Persistence.ProducOrders.Command
{
    public class DeleteProductOrderRangeCommand : IDeleteProductOrderRangeCommand
    {
        private readonly AppDbContext _appDbContext;

        public DeleteProductOrderRangeCommand(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Delete(IList<ProductOrder> productOrders)
        {
            _appDbContext.ProductOrders.RemoveRange(productOrders);
            _appDbContext.SaveChanges();
        }
    }
}

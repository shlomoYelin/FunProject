using FunProject.Application.Data.Orders.Command;
using FunProject.Domain.Entities;

namespace FunProject.Persistence.Orders.Command
{
    public class DeleteOrderCommand : IDeleteOrderCommand
    {
        private readonly AppDbContext _appDbContext;

        public DeleteOrderCommand(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Delete(Order order)
        {
            _appDbContext.Orders.Remove(order);
            _appDbContext.SaveChangesAsync();
        }
    }
}

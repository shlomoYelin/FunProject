using FunProject.Application.Data.Customers.Command;
using FunProject.Domain.Entities;

namespace FunProject.Persistence.Customers.Command
{
    public class DeleteCustomerCommand : IDeleteCustomerCommand
    {
        private readonly AppDbContext _appDbContext;

        public DeleteCustomerCommand(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Delete(Customer customer)
        {
            _appDbContext.Customers.Remove(customer);
            _appDbContext.SaveChangesAsync();
        }
    }
}

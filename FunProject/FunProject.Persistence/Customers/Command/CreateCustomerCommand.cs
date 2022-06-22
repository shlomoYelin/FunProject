using FunProject.Application.Data.Customers.Command;
using FunProject.Domain.Entities;

namespace FunProject.Persistence.Customers.Command
{
    public class CreateCustomerCommand : ICreateCustomerCommand
    {
        private readonly AppDbContext _appDbContext;

        public CreateCustomerCommand(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Customer Create(Customer customer)
        {
            _appDbContext.Customers.Add(customer);
            _appDbContext.SaveChangesAsync();
            return customer;
        }
    }
}

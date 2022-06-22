using FunProject.Domain.Entities;

namespace FunProject.Application.Data.Customers.Command
{
    public interface ICreateCustomerCommand
    {
        Customer Create(Customer customer);
    }
}

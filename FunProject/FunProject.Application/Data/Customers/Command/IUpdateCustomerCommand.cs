using FunProject.Domain.Entities;

namespace FunProject.Application.Data.Customers.Command
{
    public interface IUpdateCustomerCommand
    {
        Customer Update(Customer customer);
    }
}

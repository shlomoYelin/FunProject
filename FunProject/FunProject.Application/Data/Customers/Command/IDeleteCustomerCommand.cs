using FunProject.Domain.Entities;

namespace FunProject.Application.Data.Customers.Command
{
    public interface IDeleteCustomerCommand
    {
        void Delete(Customer customer);
    }
}

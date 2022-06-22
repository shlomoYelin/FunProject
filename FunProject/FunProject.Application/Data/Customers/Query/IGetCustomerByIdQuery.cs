using FunProject.Domain.Entities;

namespace FunProject.Application.Data.Customers.Query
{
    public interface IGetCustomerByIdQuery
    {
        Customer Get(int id);   
    }
}

using FunProject.Application.Data.Customers.Query;
using FunProject.Domain.Entities;
using System.Linq;

namespace FunProject.Persistence.Customers.Query
{
    public class GetCustomerByIdQuery : IGetCustomerByIdQuery
    {
        private readonly AppDbContext _appDbContext;

        public GetCustomerByIdQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Customer Get(int id)
        {
            return _appDbContext.Customers.First(x => x.Id == id);
        }
    }
}

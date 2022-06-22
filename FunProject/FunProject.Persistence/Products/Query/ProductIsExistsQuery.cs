using FunProject.Application.Data.Products.Query;
using System.Linq;

namespace FunProject.Persistence.Products.Query
{
    public class ProductIsExistsQuery : IProductIsExistsQuery
    {
        private readonly AppDbContext _appDbContext;

        public ProductIsExistsQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public bool IsExists(int id)
        {
            return _appDbContext.Products.Any(p => p.Id == id);
        }
    }
}

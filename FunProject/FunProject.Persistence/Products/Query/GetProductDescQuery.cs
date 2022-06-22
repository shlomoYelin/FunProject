using FunProject.Application.Data.Products.Query;
using System.Linq;

namespace FunProject.Persistence.Products.Query
{
    public class GetProductDescQuery : IGetProductDescQuery
    {
        private readonly AppDbContext _appDbContext;

        public GetProductDescQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public string Get(int id)
        {
            return _appDbContext.Products.Where(p => p.Id == id).Select(p => p.Description).FirstOrDefault();
        }
    }
}

using FunProject.Application.Data.Products.Query;
using System.Linq;

namespace FunProject.Persistence.Products.Query
{
    public class GetProductPriceQuery : IGetProductPriceQuery
    {
        private readonly AppDbContext _appDbContext;

        public GetProductPriceQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public float Get(int productId)
        {
            return _appDbContext.Products
                .Where(p => p.Id == productId)
                .Select(p => p.Price)
                .FirstOrDefault();
        }
    }
}

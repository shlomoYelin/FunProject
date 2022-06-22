using FunProject.Application.Data.Products.Query;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Persistence.Products.Query
{
    public class GetProductsDesByIdsQuery : IGetProductsDesByIdsQuery
    {
        private readonly AppDbContext _appDbContext;

        public GetProductsDesByIdsQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IList<(int, string)> Get(IList<int> Ids)
        {
            return _appDbContext.Products
                .Where(p => Ids.Contains(p.Id))
                .Select(p => new System.ValueTuple<int, string>(p.Id, p.Description))
                .ToList();
        }
    }
}

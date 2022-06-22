using FunProject.Application.Data.Products.Query;
using FunProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FunProject.Persistence.Products.Query
{
    public class AllProductsQuery : IAllProductsQuery
    {
        private readonly AppDbContext _appDbContext;

        public AllProductsQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IList<Product>> Get()
        {
            return await _appDbContext.Products.ToListAsync();
        }
    }
}

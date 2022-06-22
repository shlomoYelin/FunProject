using FunProject.Application.Data.Products.Query;
using FunProject.Application.ProductsModule.Dtos;
using FunProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Persistence.Products.Query
{
    public class GetProductsBySearchValueQuery : IGetProductsBySearchValueQuery
    {
        private readonly AppDbContext _appDbContext;

        public GetProductsBySearchValueQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IList<Product> Get(string searchValue)
        {
            return _appDbContext.Products
                .Where(p => p.Description.ToLower()
                .Contains(searchValue.ToLower()))
                .ToList();
        }
    }
}

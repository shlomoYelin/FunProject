using FunProject.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FunProject.Application.Data.Products.Query
{
    public interface IAllProductsQuery
    {
        Task<IList<Product>> Get();
    }
}

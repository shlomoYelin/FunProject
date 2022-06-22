using FunProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Application.Data.Products.Query
{
    public interface IGetProductsBySearchValueQuery
    {
        IList<Product> Get(string searchValue);
    }
}

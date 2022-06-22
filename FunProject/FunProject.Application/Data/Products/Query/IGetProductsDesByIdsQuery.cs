using System.Collections.Generic;

namespace FunProject.Application.Data.Products.Query
{
    public interface IGetProductsDesByIdsQuery
    {
        IList<(int Id, string Description)> Get(IList<int> Ids);
    }
}

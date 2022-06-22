using System.Collections.Generic;


namespace FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces
{
    public interface IGetProductsByIdsTask
    {
        IList<(int Id, string Description)> Get(IList<int> ids);
    }
}

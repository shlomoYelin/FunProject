using FunProject.Application.ProductsModule.Dtos;
using System.Collections.Generic;

namespace FunProject.Application.ProductsModule.WorkFlows.Interfaces
{
    public interface IGetAllProductWorkFlow
    {
        IList<ProductDto> Get();
    }
}

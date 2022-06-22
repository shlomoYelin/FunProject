using FunProject.Application.ProductsModule.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces
{
    public interface IGetProductsBySearchValueTask
    {
        IList<ProductDto> Get(string searchValue);
    }
}

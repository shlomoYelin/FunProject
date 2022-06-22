using FunProject.Application.ProductOrderModule.Dtos;
using FunProject.Domain.Entities;
using FunProject.Domain.Enums;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IProductOrderGetActionTypeTask
    {
        ActionType Get(ProductOrder dbProducOrder, ProductOrderDto clientProductOrder);
    }
}

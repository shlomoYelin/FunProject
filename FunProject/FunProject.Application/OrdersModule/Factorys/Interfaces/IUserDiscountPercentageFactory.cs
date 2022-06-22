using FunProject.Application.OrdersModule.Factorys.DiscountPercentage.Interfaces;
using FunProject.Domain.Enums;

namespace FunProject.Application.OrdersModule.Factorys.Interfaces
{
    public interface IUserDiscountPercentageFactory
    {
        IGetUserDiscountPercentage Get(UserType userType);
    }
}

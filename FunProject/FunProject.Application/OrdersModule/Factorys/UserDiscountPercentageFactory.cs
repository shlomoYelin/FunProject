using FunProject.Application.OrdersModule.Factorys.DiscountPercentage;
using FunProject.Application.OrdersModule.Factorys.DiscountPercentage.Interfaces;
using FunProject.Application.OrdersModule.Factorys.Interfaces;
using FunProject.Domain.Enums;

namespace FunProject.Application.OrdersModule.Factorys
{
    public class UserDiscountPercentageFactory : IUserDiscountPercentageFactory
    {
        public IGetUserDiscountPercentage Get(UserType userType)
        {
            switch (userType)
            {
                case UserType.Guest:
                    return new GetGuestDiscountPercentage();

                case UserType.Regular:
                    return new GetRegularDiscountPercentage();

                case UserType.Vip:
                    return new GetVipDiscountPercentage();

                case UserType.Manager:
                    return new GetManagerDiscountPercentage();

                default:
                    return new GetGuestDiscountPercentage();
            }
        }
    }
}

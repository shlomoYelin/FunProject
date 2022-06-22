using FunProject.Domain.Enums;

namespace FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces
{
    public interface IGetCustomerTypeTask
    {
        UserType Get(int customerId);
    }
}

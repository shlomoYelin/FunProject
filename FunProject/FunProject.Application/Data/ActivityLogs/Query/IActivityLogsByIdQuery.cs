using FunProject.Domain.Entities;
using System.Threading.Tasks;

namespace FunProject.Application.Data.ActivityLogs.Query
{
    public interface IActivityLogsByIdQuery
    {
        Task<ActivityLog> Get(int? id);
    }
}

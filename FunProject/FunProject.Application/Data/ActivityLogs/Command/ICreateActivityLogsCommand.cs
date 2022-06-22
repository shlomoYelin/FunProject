using FunProject.Domain.Entities;
using System.Threading.Tasks;

namespace FunProject.Application.Data.ActivityLogs.Command
{
    public interface ICreateActivityLogsCommand
    {
        Task<ActivityLog> Create(ActivityLog activityLog);
    }
}

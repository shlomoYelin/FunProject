using FunProject.Application.Data.ActivityLogs.Command;
using FunProject.Domain.Entities;
using System.Threading.Tasks;

namespace FunProject.Persistence.ActivityLogs.Command
{
    public class CreateActivityLogCommand : ICreateActivityLogsCommand
    {
        private readonly AppDbContext _appDbContext;
        public CreateActivityLogCommand(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<ActivityLog> Create(ActivityLog activityLog)
        {
            _appDbContext.ActivityLogs.Add(activityLog);
            await _appDbContext.SaveChangesAsync();
            return activityLog;
        }
    }
}

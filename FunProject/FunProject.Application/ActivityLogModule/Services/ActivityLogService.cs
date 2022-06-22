using FunProject.Application.ActivityLogModule.Dtos;
using FunProject.Application.ActivityLogModule.Services.Interfaces;
using FunProject.Application.Data.ActivityLogs.Command;
using FunProject.Application.Data.ActivityLogs.Query;
using FunProject.Domain.Entities;
using FunProject.Domain.Logger;
using FunProject.Domain.Mapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FunProject.Application.ActivityLogModule.Services
{
    public class ActivityLogService : IActivityLogService
    {
        private readonly ILoggerAdapter<ActivityLogService> _logger;
        private readonly IMapperAdapter _mapperAdapter;
        private readonly IAllActivityLogsQuery _allActivityLogsQuery;
        private readonly ICreateActivityLogsCommand _createActivityLogsCommand;

        public ActivityLogService(
            ILoggerAdapter<ActivityLogService> logger,
            IMapperAdapter mapperAdapter,
            IAllActivityLogsQuery allActivityLogsQuery,
            ICreateActivityLogsCommand createActivityLogsCommand)
        {
            _logger = logger;
            _mapperAdapter = mapperAdapter;
            _allActivityLogsQuery = allActivityLogsQuery;
            _createActivityLogsCommand = createActivityLogsCommand;
        }

        public async Task<ActivityLogDto> CreateActivityLog(string Message, Domain.Enums.ActionType actionType)
        {
            _logger.LogInformation("Method CreateActivityLog Invoked.");
            try
            {
                var createdActivityLog = await _createActivityLogsCommand.Create(_mapperAdapter.Map<ActivityLog>(
                    new ActivityLogDto() { Id = 0, ActionType = actionType, ActivityDate = DateTime.Now, Message = Message })
                    );
                return _mapperAdapter.Map<ActivityLogDto>(createdActivityLog);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Method CreateActivityLog failed.");
                throw;
            }

        }



        public async Task<IList<ActivityLogDto>> GetAllActivityLogs()
        {
            _logger.LogInformation("Method GetAllActivityLogs Invoked.");
            try
            {
                return _mapperAdapter.Map<IList<ActivityLogDto>>(await _allActivityLogsQuery.Get());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Method GetAllActivityLogs failed.");
                throw;
            }
        }
    }
}

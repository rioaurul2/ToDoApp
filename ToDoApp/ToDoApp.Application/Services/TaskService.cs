using Microsoft.Extensions.Logging;
using ToDoApp.Application.Interfaces;
using ToDoApp.Domain.Entities;
using ToDoApp.Domain.Interfaces;

namespace ToDoApp.Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskItemRepository _taskItemRepository;
        private readonly ILogger<TaskService> _logger;

        public TaskService(ITaskItemRepository taskItemRepository, ILogger<TaskService> logger)
        {
            _taskItemRepository = taskItemRepository;
            _logger = logger;
        }

        public async Task<IEnumerable<TaskItem>> GetAllTaskItems(CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Process started: {Service}.{Method}", nameof(TaskService), nameof(GetAllTaskItems));

                var taskItems = await _taskItemRepository.GetAllTaskItems(cancellationToken);

                _logger.LogInformation($"Process ended without issues");

                return taskItems;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Process ended with issues");
                throw;
            }
        }
    }
}

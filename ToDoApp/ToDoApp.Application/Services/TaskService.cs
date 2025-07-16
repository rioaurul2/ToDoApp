using Microsoft.Extensions.Logging;
using ToDoApp.Application.Exceptions;
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

                var result = await _taskItemRepository.GetAllTaskItems(cancellationToken);

                _logger.LogInformation($"Process ended without issues");

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Process ended with issues");
                throw;
            }
        }

        public async Task<TaskItem> GetTaskItemById(int id, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Process started: {Service}.{Method}", nameof(TaskService), nameof(GetAllTaskItems));

                var result = await _taskItemRepository.GetTaskItemById(id, cancellationToken);

                _logger.LogInformation($"Process ended without issues");

                if(result == null)
                {
                    throw new NotFoundException($"Task with ID {id} not found.");
                }

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Process ended with issues");
                throw;
            }
        }
    }
}

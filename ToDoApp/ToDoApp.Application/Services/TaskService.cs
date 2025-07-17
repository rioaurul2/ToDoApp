using Microsoft.Extensions.Logging;
using ToDoApp.API.DTOs;
using ToDoApp.Application.DTOs;
using ToDoApp.Application.Exceptions;
using ToDoApp.Application.Interfaces;
using ToDoApp.Domain.Interfaces;

namespace ToDoApp.Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskItemRepository _taskItemRepository;
        private readonly ITaskItemsMapperService _taskItemsMapperService;
        private readonly ILogger<TaskService> _logger;

        public TaskService(
            ITaskItemRepository taskItemRepository,
            ITaskItemsMapperService taskItemsMapperService,
            ILogger<TaskService> logger)
        {
            _taskItemRepository = taskItemRepository;
            _taskItemsMapperService = taskItemsMapperService;
            _logger = logger;
        }

        public async Task<IEnumerable<TaskItemDto>> GetAllTaskItems(CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Process started: {Service}.{Method}", nameof(TaskService), nameof(GetAllTaskItems));

                var result = await _taskItemRepository.GetAllTaskItems(cancellationToken);

                var resultDto = _taskItemsMapperService.MapTaskItemsListToDto([..result]);

                _logger.LogInformation($"Process ended without issues");

                return resultDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Process ended with issues");
                throw;
            }
        }

        public async Task<TaskItemDto> GetTaskItemById(int id, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Process started: {Service}.{Method}", nameof(TaskService), nameof(GetAllTaskItems));

                var result = await _taskItemRepository.GetTaskItemById(id, cancellationToken);

                if (result == null)
                {
                    throw new NotFoundException($"Task with ID {id} not found.");
                }

                var resultDto = _taskItemsMapperService.MapTaskItemToDto(result);

                _logger.LogInformation($"Process ended without issues");

                return resultDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Process ended with issues");
                throw;
            }
        }

        public async Task CreateTaskItem(CreateTaskItemDto taskItemDto, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Process started: {Service}.{Method}", nameof(TaskService), nameof(CreateTaskItem));

                var taskItem = _taskItemsMapperService.MapDtoToTaskItem(taskItemDto);

                await _taskItemRepository.CreateTaskItem(taskItem, cancellationToken);

                _logger.LogInformation($"Process ended without issues");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Process ended with issues");
                throw;
            }
        }
    }
}

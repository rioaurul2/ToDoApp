using ToDoApp.Application.Interfaces;
using ToDoApp.Domain.Entities;
using ToDoApp.Domain.Interfaces;

namespace ToDoApp.Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskItemRepository _taskItemRepository;

        public TaskService(ITaskItemRepository taskItemRepository)
        {
            _taskItemRepository = taskItemRepository;
        }

        public async Task<IEnumerable<TaskItem>> GetAllTaskItems(CancellationToken cancellationToken)
        {
            var taskItems = await _taskItemRepository.GetAllTaskItems(cancellationToken);

            return taskItems;
        }
    }
}

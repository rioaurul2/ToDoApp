using ToDoApp.Domain.Entities;

namespace ToDoApp.Domain.Interfaces;

public interface ITaskItemRepository
{
    Task<IEnumerable<TaskItem>> GetAllTaskItems(CancellationToken cancellationToken);
    Task<TaskItem?> GetTaskItemById(int id, CancellationToken cancellationToken);
    Task CreateTaskItem(TaskItem item, CancellationToken cancellationToken);

}

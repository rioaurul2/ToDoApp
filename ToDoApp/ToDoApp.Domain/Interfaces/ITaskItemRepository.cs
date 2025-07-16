using ToDoApp.Domain.Entities;

namespace ToDoApp.Domain.Interfaces;

public interface ITaskItemRepository
{
    Task<IEnumerable<TaskItem>> GetAllTaskItems(CancellationToken cancellationToken);
}

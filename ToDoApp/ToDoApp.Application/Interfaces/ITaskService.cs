using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Interfaces;

public interface ITaskService
{
    Task<IEnumerable<TaskItem>> GetAllTaskItems(CancellationToken cancellationToken);

    Task<TaskItem> GetTaskItemById(int id, CancellationToken cancellationToken);
}

using ToDoApp.Application.DTOs;

namespace ToDoApp.Application.Interfaces;

public interface ITaskService
{
    Task<IEnumerable<TaskItemDto>> GetAllTaskItems(CancellationToken cancellationToken);

    Task<TaskItemDto> GetTaskItemById(int id, CancellationToken cancellationToken);
}

using System.Threading;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Interfaces;

public interface ITaskService
{
    Task<IEnumerable<TaskItem>> GetAllTaskItems(CancellationToken cancellationToken);
}

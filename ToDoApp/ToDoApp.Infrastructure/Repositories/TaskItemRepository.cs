using Microsoft.EntityFrameworkCore;
using ToDoApp.Domain.Entities;
using ToDoApp.Domain.Interfaces;
using ToDoApp.Infrastructure.Context;

namespace ToDoApp.Infrastructure.Repositories;

public class TaskItemRepository : ITaskItemRepository
{
    private readonly ToDoDbContext _toDoDbContext;

    public TaskItemRepository(ToDoDbContext toDoDbContex)
    {
        _toDoDbContext = toDoDbContex;
    }

    public async Task<IEnumerable<TaskItem>> GetAllTaskItems(CancellationToken cancellationToken)
    {
        var taskItems = await _toDoDbContext.TaskItems.ToListAsync();

        return taskItems;
    }
}

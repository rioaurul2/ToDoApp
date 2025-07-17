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
        var result = await _toDoDbContext.TaskItems.ToListAsync(cancellationToken);

        return result;
    }

    public async Task<TaskItem?> GetTaskItemById(int id, CancellationToken cancellationToken)
    {
        var result = await _toDoDbContext.TaskItems
            .Where(item => item.Id == id)
            .FirstOrDefaultAsync(cancellationToken);

        return result;
    }

    public async Task CreateTaskItem(TaskItem item, CancellationToken cancellationToken)
    {
        await _toDoDbContext.AddAsync(item, cancellationToken);

        await _toDoDbContext.SaveChangesAsync(cancellationToken);
    }
}

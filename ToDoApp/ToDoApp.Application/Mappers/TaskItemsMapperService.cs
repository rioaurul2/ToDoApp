using ToDoApp.Application.DTOs;
using ToDoApp.Application.Interfaces;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Mappers;

public class TaskItemsMapperService : ITaskItemsMapperService
{
    public List<TaskItemDto> MapTaskItemsListToDto(List<TaskItem> taskItems)
    {
        var resultDto = new List<TaskItemDto>();

        taskItems.ForEach(taskItem =>
        {
            var taskItemDto = new TaskItemDto()
            {
                Name = taskItem.Name,
                Description = taskItem.Description,
                DataOraPlanificare = taskItem.DataOraPlanificare,
                UserId = taskItem.UserId,
            };

            resultDto.Add(taskItemDto);
        });

        return resultDto;
    }

    public TaskItemDto MapTaskItemToDto(TaskItem taskItem)
    {
        var resultDto = new TaskItemDto()
        {
            Name = taskItem.Name,
            Description = taskItem.Description,
            DataOraPlanificare = taskItem.DataOraPlanificare,
            UserId = taskItem.UserId
        };
        return resultDto;
    }
}

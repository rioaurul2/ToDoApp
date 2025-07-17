using ToDoApp.API.DTOs;
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

    public TaskItem MapDtoToTaskItem(CreateTaskItemDto taskItemDto)
    {
        var taskItem = new TaskItem()
        {
            Name = taskItemDto.Name,
            //UserId = //nu se face post pana nu avem si useri, doar useri authenticati pot face post
            Description = taskItemDto.Description,
            DataOraPlanificare = taskItemDto.DataOraPlanificare
        };

        return taskItem;
    }
}

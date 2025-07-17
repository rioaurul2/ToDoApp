using ToDoApp.API.DTOs;
using ToDoApp.Application.DTOs;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Interfaces;

public interface ITaskItemsMapperService
{
    List<TaskItemDto> MapTaskItemsListToDto(List<TaskItem> taskItems);
    TaskItemDto MapTaskItemToDto(TaskItem taskItem);
    TaskItem MapDtoToTaskItem(CreateTaskItemDto taskItemDto);
}

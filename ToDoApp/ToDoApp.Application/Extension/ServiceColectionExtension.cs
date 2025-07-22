using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using ToDoApp.Application.DTOs;
using ToDoApp.Application.Interfaces;
using ToDoApp.Application.Mappers;
using ToDoApp.Application.Services;
using ToDoApp.Application.Validators;
namespace ToDoApp.Application.Extension;

public static class ServiceColectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ITaskService, TaskService>();
        services.AddScoped<ITaskItemsMapperService, TaskItemsMapperService>();
        services.AddScoped<IValidator<CreateTaskItemDto>, CreateTaskItemDtoValidator>();
    }
}

using Microsoft.Extensions.DependencyInjection;
using ToDoApp.Application.Interfaces;
using ToDoApp.Application.Services;
namespace ToDoApp.Application.Extension;

public static class ServiceColectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ITaskService, TaskService>();
    }
}

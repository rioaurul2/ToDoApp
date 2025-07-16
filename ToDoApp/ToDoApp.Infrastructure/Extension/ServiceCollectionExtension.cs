using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ToDoApp.Domain.Interfaces;
using ToDoApp.Infrastructure.Context;
using ToDoApp.Infrastructure.Repositories;

namespace ToDoApp.Infrastructure.Extension
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //db connection
            var connectionString = configuration.GetConnectionString("DatabaseConnectionString");
            services.AddDbContext<ToDoDbContext>(options =>
                options.UseSqlServer(connectionString)
            );

            services.AddScoped<ITaskItemRepository, TaskItemRepository>();
        }
    }
}

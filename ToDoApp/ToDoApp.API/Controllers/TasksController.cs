using Microsoft.AspNetCore.Mvc;
using ToDoApp.Application.Interfaces;

namespace ToDoApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;
        private readonly ILogger<TasksController> _logger;

        public TasksController(ITaskService taskService, ILogger<TasksController> logger)
        {
            _taskService = taskService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTasks(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Process started: GetAllTasks");

            var result = await _taskService.GetAllTaskItems(cancellationToken);

            if (!result.Any())
            {
                return NoContent();
            }

            _logger.LogInformation("Process ended: GetAllTasks. Returned {Count} items", result.Count());

            return Ok(result);
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetTaskById( int id)
        //{
        //    return Ok();
        //}

        //[HttpPost]
        //public async Task <IActionResult> CreateTask([FromBody] CreateTaskDto createTask)
        //{
        //    return Ok();
        //}
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Threading;
using ToDoApp.Application.DTOs;
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
        public async Task<ActionResult<List<TaskItemDto>>> GetAllTasks(CancellationToken cancellationToken)
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

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskItemDto>> GetTaskById(int id, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Process started: {Method}", nameof(GetTaskById));

            var result = await _taskService.GetTaskItemById(id, cancellationToken);

            _logger.LogInformation("Process ended: {Method} for TaskId={TaskId}", nameof(GetTaskById), id);

            return Ok(result);
        }

        //[HttpPost]
        //public async Task <IActionResult> CreateTask([FromBody] CreateTaskDto createTask)
        //{
        //    return Ok();
        //}
    }
}

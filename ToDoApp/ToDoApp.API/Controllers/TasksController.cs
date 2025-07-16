using Microsoft.AspNetCore.Mvc;
using ToDoApp.API.DTOs;
using ToDoApp.Application.Interfaces;

namespace ToDoApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTasks()
        {
            var result = await _taskService.GetAllTaskItems(default);

            if (!result.Any())
            {
                return NoContent();
            }

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

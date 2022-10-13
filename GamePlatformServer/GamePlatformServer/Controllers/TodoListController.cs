using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace GamePlatformServer.Controllers
{
    [Authorize]
    [RequiredScope("tasks.read")]
    [ApiController]
    [Route("game-api/[controller]")]
    public class TodoListController : ControllerBase
    {
        private readonly ILogger<TodoListController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;

        public TodoListController(ILogger<TodoListController> logger, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var todoList = new List<string>()
            {
                "Task1",
                "Task2",
                "Task3"
            };
            return Ok(todoList);
        }

    }
}

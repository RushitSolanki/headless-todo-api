using Microsoft.AspNetCore.Mvc;

namespace TodoApp.API.Controllers
{
    [ApiController]
    [Route("/")]
    public class RootController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(new { message = "Welcome to the Headless TODO API!", date = DateTime.UtcNow });
    }
}
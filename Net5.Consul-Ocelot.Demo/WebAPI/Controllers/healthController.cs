using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("health")]
    [ApiController]
    public class healthController : Controller
    {
        public IActionResult Get() => Ok("ok");
    }
}

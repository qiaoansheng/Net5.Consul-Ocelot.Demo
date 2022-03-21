using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/Demo")]
    [ApiController]
    public class DemoController : Controller
    {
        [HttpGet]
        public IActionResult Get(string id)
        {
            return Json(new
            {
                id = id
            });
        }

        [HttpPost]
        public IActionResult Post(UserDto userDto)
        {
            return Json(new
            {
                UserName = userDto.UserName,
                UserId = userDto.UserId
            });
        }
    }
}

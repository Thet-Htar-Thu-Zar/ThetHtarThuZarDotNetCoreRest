using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ThetHtarThuZarDotNetCore.RestApi.Controllers
{
    //api/User
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Greeting()
        {
            //return Ok("Welcome");

            return StatusCode(StatusCodes.Status200OK, "Welcome😍!");
        }
    }
}

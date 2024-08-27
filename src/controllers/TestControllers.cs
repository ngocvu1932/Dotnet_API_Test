using Microsoft.AspNetCore.Mvc;
using simpleapi.src.models;

namespace simpleapi.src.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("/hello")]
        public ActionResult<string> Get() {
            return "Hello World!";
        }

        [HttpPost("/compare")]
        public ActionResult<bool> CompareObject([FromBody] User user) {
            string name = "Vu";

            if (user.Name != null && user.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            } else {
                return false;
            }
        } 
    }
}
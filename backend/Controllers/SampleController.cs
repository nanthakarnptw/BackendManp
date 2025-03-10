using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Hello from Sample API!" });
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok(new { message = $"Received value: {value}" });
        }
    }
}

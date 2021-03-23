using Microsoft.AspNetCore.Mvc;

namespace micolk_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new OkResult();
        }
    }
}

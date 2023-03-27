using Microsoft.AspNetCore.Mvc;

namespace backend_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class DespreController : ControllerBase
    {

        private readonly ILogger<DespreController> _logger;

        public DespreController(ILogger<DespreController> logger)
        {
            _logger = logger;
        }
    }
}

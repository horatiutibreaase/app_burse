using Microsoft.AspNetCore.Mvc;

namespace backend_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class JurnalController : ControllerBase
    {

        private readonly ILogger<JurnalController> _logger;

        public JurnalController(ILogger<JurnalController> logger)
        {
            _logger = logger;
        }

    }
}

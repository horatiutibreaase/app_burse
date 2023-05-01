using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MySqlConnector;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace backend_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class HomeController : ControllerBase
    {

        //TEST GIT
        private readonly ILogger<HomeController> _logger;
        private readonly String username = "admin";
        private readonly String password = "admin";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost("/verifica/utilizator")]
        public IActionResult VerificaUtilizator([FromBody] temp_Utilizator u)
        {

            if (u.username.Equals(username) && u.password.Equals(password))
            {
                return Ok("User si parola gasite");
            }
            else
            {
                return NotFound("Date invalide de conectare");
            }
        }

    }
}

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
        private readonly temp_Utilizator admin;
        private readonly temp_Utilizator secretariat;

        public HomeController(ILogger<HomeController> logger)
        {
            admin = new temp_Utilizator("admin","admin");
            secretariat = new temp_Utilizator("secretariat", "secretariat");
            _logger = logger;
        }

        [HttpPost("/verifica/utilizator")]
        public IActionResult VerificaUtilizator([FromBody] temp_Utilizator u)
        {

            if (u.username.Equals(admin.username) && u.password.Equals(admin.password))
            {
                return Ok("Admin - User si parola gasite");
            }
            else if(u.username.Equals(secretariat.username) && u.password.Equals(secretariat.password))
            {
                return Ok("Secretariat - User si parola gasite");
            }
            else
            {
                return NotFound("Date de conectare invalide");
            }
        }

    }
}

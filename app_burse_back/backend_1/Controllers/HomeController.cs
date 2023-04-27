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

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost("/verifica/utilizator")]
        public async Task<IActionResult> VerificaUtilizator([FromBody] temp_Utilizator u)
        {
            temp_Facultate f = new temp_Facultate();

            u.username = "Alex";
            u.password = "alexPass";

            if (u.username.Contains("_"))
            {

                f.faculate = u.username.Split("_")[1].ToUpper();
            }

            Console.WriteLine(u.username);
            Console.WriteLine(u.password);

            try
            {
                MySqlConnection connection = MyConnection.getConnection().Result;
                using MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM utilizatori " +
                    "WHERE username = @username AND password = @password ";
                command.Parameters.AddWithValue("@username", u.username);
                command.Parameters.AddWithValue("@password", u.password);

                MySqlDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    reader.Close();
                    connection.Close();
                    return Ok("User si parola gasite");
                }
                reader.Close();
                connection.Close();
                return NotFound("Date invalide de conectare");
            }
            catch (SqlException e)
            {
                _logger.LogError(e, "A aparut o eroare in timpul conexiunii la baza de date");
                return StatusCode(500);
            }
        }

        


    }
}

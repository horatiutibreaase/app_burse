using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MySqlConnector;

namespace backend_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class CuantumController : ControllerBase
    {
        private readonly ILogger<CuantumController> _logger;

        public CuantumController(ILogger<CuantumController> logger)
        {
            _logger = logger;
        }

        [HttpPost("/verifica/utilizator")]
        public async Task<IActionResult> VerificaUtilizator()
        {
            Utilizator u = new Utilizator();
            Facultate f = new Facultate();

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

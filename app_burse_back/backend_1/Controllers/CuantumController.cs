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

        [HttpPut("/studenti/refreshAwards")]
        public IActionResult refreshAwards([FromBody] temp_Burse b)
        {
            int rowsAffected = 0;

            try
            {
                MySqlConnection connection = MyConnection.getConnection().Result;
                using MySqlCommand command = connection.CreateCommand();

                command.CommandText = "UPDATE burse SET denumire = @denumire, cuantum = @cuantum WHERE id = @id";
                command.Parameters.AddWithValue("@denumire", b.nume);
                command.Parameters.AddWithValue("@cuantum", b.cuantum);
                command.Parameters.AddWithValue("@id", b.id);


                rowsAffected = command.ExecuteNonQuery();

                connection.Close();
                return Ok(rowsAffected + "rows affected");
            }
            catch (SqlException e)
            {
                _logger.LogError(e, "A aparut o eroare in timpul conexiunii la baza de date");
                return StatusCode(500);
            }

        }
    }
}

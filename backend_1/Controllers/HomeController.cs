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

        [HttpPut("/studenti/refreshAwards")]
        public IActionResult refreshAwards([FromBody]Burse b)
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

        //de completat 
        [HttpPost("/genereazaPDF")]
        public void genereazaPDF([FromBody]Facultate f)
        {

            MySqlConnection connection = MyConnection.getConnection().Result;

            using var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM studenti s, burse_alocate bs " +
                "WHERE s.facultate = ? AND s.anStudiu = ? AND s.cicluInvatamant = ? AND s.id = bs.id AND bs.idBursa = ?;";
        }
    }
}

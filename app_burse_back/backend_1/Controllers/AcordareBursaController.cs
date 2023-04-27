using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MySqlConnector;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace backend_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class AcordareBursaController : ControllerBase
    {

        private readonly ILogger<AcordareBursaController> _logger;

        public AcordareBursaController(ILogger<AcordareBursaController> logger)
        {
            _logger = logger;
        }

        //de modificat
        [HttpPost("/studenti/facultate")]
        public async Task<ActionResult> CitireDateStudent([FromBody] JsonObject obj) 
        {
            var facultate = obj["facultate"]?.ToString();
            var anStudiu = obj["anStudiu"]?.ToString();
            var cicluInvatamant = obj["cicluInvatamant"]?.ToString();
            var idStudent = obj["idStudent"]?.ToString();
            var idBursa = obj["idBursa"]?.ToString();

            List<temp_Student> students = new List<temp_Student>(); 
            try
            {
                MySqlConnection connection = MyConnection.getConnection().Result;
                using MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM studenti s, burse_alocate bs " +
                    "WHERE s.FACULTATE = @facultate AND s.AN_STUDIU = @anStudiu AND s.CICLU_INVATAMANT = @cicluInvatamant" +
                    " AND s.ID_STUDENT = @idStudent AND s.ID_BURSA = @idBursa and s.ID_STUDENT NOT IN (SELECT id from burse_alocate)";
                command.Parameters.AddWithValue("@facultate", facultate);
                command.Parameters.AddWithValue("@anStudiu", anStudiu);
                command.Parameters.AddWithValue("@cicluInvatamant", cicluInvatamant);
                command.Parameters.AddWithValue("@idStudent", idStudent);
                command.Parameters.AddWithValue("@idBursa", idBursa);

                MySqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    temp_Student student = new temp_Student();

                    student.facultate = reader.GetString("FACULTATE");
                    student.anStudiu = reader.GetString("AN_STUDIU");
                    student.cicluInvatamant = reader.GetString("CICLU_INVATAMANT");
                    student.idStudent = reader.GetString("ID_STUDENT");
                    student.idBursa = reader.GetString("ID_BURSA");
                    students.Add(student);
                }

                reader.Close();
                connection.Close();

                string studentsJson = JsonSerializer.Serialize(students);

                return Ok(studentsJson);

            }
            catch (SqlException e)
            {
                _logger.LogError(e, "A aparut o eroare in timpul conexiunii la baza de date");
                return StatusCode(500);
            }

        }


        //de modificat
        [HttpPost("/studenti/facultate/burse/alocate")]
        public async Task<ActionResult> AcordareBurse([FromBody] JsonObject obj)
        {
            var facultate = obj["facultate"]?.ToString();
            var anStudiu = obj["anStudiu"]?.ToString();
            var cicluInvatamant = obj["cicluInvatamant"]?.ToString();
            var tipBursa = obj["tipBursa"]?.ToString();

            List<temp_Student> students = new List<temp_Student>();
            try
            {
                MySqlConnection connection = MyConnection.getConnection().Result;
                using MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM studenti s, burse_alocate bs " +
                    "WHERE s.FACULTATE = @facultate AND s.AN_STUDIU = @anStudiu AND s.CICLU_INVATAMANT" +
                    " = @cicluInvatamant AND s.ID_STUDENT = bs.id AND bs.ID_BURSA = @tipBursa";
                command.Parameters.AddWithValue("@facultate", facultate);
                command.Parameters.AddWithValue("@anStudiu", anStudiu);
                command.Parameters.AddWithValue("@cicluInvatamant", cicluInvatamant);
                command.Parameters.AddWithValue("@tipBursa", tipBursa);

                MySqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    temp_Student student = new temp_Student();

                    student.facultate = reader.GetString("FACULTATE");
                    student.anStudiu = reader.GetString("AN_STUDIU");
                    student.cicluInvatamant = reader.GetString("CICLU_INVATAMANT");
                    student.idStudent = reader.GetString("ID_STUDENT");
                    student.idBursa = reader.GetString("ID_BURSA");
                    students.Add(student);
                }

                reader.Close();
                connection.Close();

                string studentsJson = JsonSerializer.Serialize(students);

                return Ok(studentsJson);

            }
            catch (SqlException e)
            {
                _logger.LogError(e, "A aparut o eroare in timpul conexiunii la baza de date");
                return StatusCode(500);
            }
        }


        [HttpPost("/studenti/facultate/admBurse")]
        public async Task<ActionResult> admBurse([FromBody] JsonObject obj)
        {
            var facultate = obj["facultate"]?.ToString();
            var anStudiu = obj["anStudiu"]?.ToString();
            var tipBursa = obj["tipBursa"]?.ToString();

            Console.WriteLine("Request1: " + facultate + " " + anStudiu + " " + tipBursa);

            List<temp_Student> students = new List<temp_Student>();
            try
            {
                MySqlConnection connection = MyConnection.getConnection().Result;
                using MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM studenti s, burse_alocate bs" +
                    " WHERE s.FACULTATE =@facultate AND s.AN_STUDIU = @anStudiu AND s.ID_STUDENT = bs.id AND bs.ID_BURSA = @tipBursa";
                command.Parameters.AddWithValue("@facultate", facultate);
                command.Parameters.AddWithValue("@tipBursa", tipBursa);
                command.Parameters.AddWithValue("@anStudiu", anStudiu);

                MySqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    temp_Student student = new temp_Student();

                    student.facultate = reader.GetString("FACULTATE");
                    student.anStudiu = reader.GetString("AN_STUDIU");
                    student.cicluInvatamant = reader.GetString("CICLU_INVATAMANT");
                    student.idStudent = reader.GetString("ID_STUDENT");
                    student.idBursa = reader.GetString("ID_BURSA");
                    students.Add(student);
                }

                reader.Close();
                connection.Close();

                string studentsJson = JsonSerializer.Serialize(students);

                return Ok(studentsJson);

            }
            catch (SqlException e)
            {
                _logger.LogError(e, "A aparut o eroare in timpul conexiunii la baza de date");
                return StatusCode(500);
            }
        }

        [HttpPost("/studenti/acorda/burse")]
        public IActionResult updateBurse()
        {
            int[] idStudenti = { 10, 12, 23, 14 };
            string tipBursa = "Buget";
            int rowsAffected = 0;

            try
            {
                MySqlConnection connection = MyConnection.getConnection().Result;
                using MySqlCommand command = connection.CreateCommand();
                for (int i = 0; i < idStudenti.Length; i++)
                {
                    command.Parameters.Clear();
                    command.CommandText = "INSERT INTO burse_alocate (id, id_bursa) VALUES (@idStudent, @tipBursa)";
                    command.Parameters.AddWithValue("@idStudent", idStudenti[i]);
                    command.Parameters.AddWithValue("@tipBursa", tipBursa);
                    rowsAffected += command.ExecuteNonQuery();

                }

                connection.Close();
                return Ok(rowsAffected + "rows affected");
            }
            catch (SqlException e)
            {
                _logger.LogError(e, "A aparut o eroare in timpul conexiunii la baza de date");
                return StatusCode(500);
            }
        }

        [HttpDelete("/studenti/sterge/burse")]
        public IActionResult StergereBurse()
        {
            int[] idStudenti = { 10, 12, 23, 14 };
            int rowsAffected = 0;

            try
            {
                MySqlConnection connection = MyConnection.getConnection().Result;
                using MySqlCommand command = connection.CreateCommand();
                for (int i = 0; i < idStudenti.Length; i++)
                {
                    command.Parameters.Clear();
                    command.CommandText = "DELETE FROM burse_alocate WHERE id=@idStudent";
                    command.Parameters.AddWithValue("@idStudent", idStudenti[i]);
                    rowsAffected += command.ExecuteNonQuery();
                }

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
        public void genereazaPDF([FromBody] temp_Facultate f)
        {

            MySqlConnection connection = MyConnection.getConnection().Result;

            using var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM studenti s, burse_alocate bs " +
                "WHERE s.facultate = ? AND s.anStudiu = ? AND s.cicluInvatamant = ? AND s.id = bs.id AND bs.idBursa = ?;";
        }


    }
}

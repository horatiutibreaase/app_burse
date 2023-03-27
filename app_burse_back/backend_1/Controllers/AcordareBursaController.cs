using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MySqlConnector;

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

        [HttpPost("/studenti/facultate")]
        public async Task<ActionResult> CitireDateStudent([FromBody] Student s)
        {
            List<Student> students = new List<Student>();
            try
            {
                MySqlConnection connection = MyConnection.getConnection().Result;
                using MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM studenti s, burse_alocate bs " +
                    "WHERE s.FACULTATE = @facultate AND s.AN_STUDIU = @anStudiu AND s.CICLU_INVATAMANT = @cicluInvatamant" +
                    " AND s.ID_STUDENT = @idStudent AND s.ID_BURSA = @idBursa and s.ID_STUDENT NOT IN (SELECT id from burse_alocate)";
                command.Parameters.AddWithValue("@facultate", s.facultate);
                command.Parameters.AddWithValue("@anStudiu", s.anStudiu);
                command.Parameters.AddWithValue("@cicluInvatamant", s.cicluInvatamant);
                command.Parameters.AddWithValue("@idStudent", s.idStudent);
                command.Parameters.AddWithValue("@idBursa", s.idBursa);

                MySqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    Student student = new Student();

                    student.facultate = reader.GetString("FACULTATE");
                    student.anStudiu = reader.GetString("AN_STUDIU");
                    student.cicluInvatamant = reader.GetString("CICLU_INVATAMANT");
                    student.idStudent = reader.GetString("ID_STUDENT");
                    student.idBursa = reader.GetString("ID_BURSA");
                    students.Add(student);
                }

                reader.Close();
                connection.Close();

                return Ok(students);

            }
            catch (SqlException e)
            {
                _logger.LogError(e, "A aparut o eroare in timpul conexiunii la baza de date");
                return StatusCode(500);
            }

        }



        [HttpPost("/studenti/facultate/burse/alocate")]
        public async Task<ActionResult> AcordareBurse([FromBody] Student s)
        {
            List<Student> students = new List<Student>();
            try
            {
                MySqlConnection connection = MyConnection.getConnection().Result;
                using MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM studenti s, burse_alocate bs " +
                    "WHERE s.FACULTATE = @facultate AND s.AN_STUDIU = @anStudiu AND s.CICLU_INVATAMANT" +
                    " = @cicluInvatamant AND s.ID_STUDENT = bs.id AND bs.ID_BURSA = @tipBursa";
                command.Parameters.AddWithValue("@facultate", s.facultate);
                command.Parameters.AddWithValue("@anStudiu", s.anStudiu);
                command.Parameters.AddWithValue("@cicluInvatamant", s.cicluInvatamant);
                command.Parameters.AddWithValue("@tipBursa", s.tipBursa);

                MySqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    Student student = new Student();

                    student.facultate = reader.GetString("FACULTATE");
                    student.anStudiu = reader.GetString("AN_STUDIU");
                    student.cicluInvatamant = reader.GetString("CICLU_INVATAMANT");
                    student.idStudent = reader.GetString("ID_STUDENT");
                    student.idBursa = reader.GetString("ID_BURSA");
                    students.Add(student);
                }

                reader.Close();
                connection.Close();

                return Ok(students);

            }
            catch (SqlException e)
            {
                _logger.LogError(e, "A aparut o eroare in timpul conexiunii la baza de date");
                return StatusCode(500);
            }
        }


        [HttpPost("/studenti/facultate/admBurse")]
        public async Task<ActionResult> admBurse([FromBody] Student s)
        {
            Console.WriteLine("Request1: " + s.facultate + " " + s.anStudiu + " " + s.tipBursa);

            List<Student> students = new List<Student>();
            try
            {
                MySqlConnection connection = MyConnection.getConnection().Result;
                using MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM studenti s, burse_alocate bs" +
                    " WHERE s.FACULTATE =@facultate AND s.AN_STUDIU = @anStudiu AND s.ID_STUDENT = bs.id AND bs.ID_BURSA = @tipBursa";
                command.Parameters.AddWithValue("@facultate", s.facultate);
                command.Parameters.AddWithValue("@tipBursa", s.tipBursa);
                command.Parameters.AddWithValue("@anStudiu", s.anStudiu);

                MySqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    Student student = new Student();

                    student.facultate = reader.GetString("FACULTATE");
                    student.anStudiu = reader.GetString("AN_STUDIU");
                    student.cicluInvatamant = reader.GetString("CICLU_INVATAMANT");
                    student.idStudent = reader.GetString("ID_STUDENT");
                    student.idBursa = reader.GetString("ID_BURSA");
                    students.Add(student);
                }

                reader.Close();
                connection.Close();

                return Ok(students);

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


    }
}

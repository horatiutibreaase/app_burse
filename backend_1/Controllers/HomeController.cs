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


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[HttpGet("Student")]
        //public async Task<string> Get2()
        //{
        //    try
        //    {
        //        MySqlDataReader reader =  MyConnection.getReader("SELECT * FROM studenti").Result;

        //        if(reader != null)
        //        {
        //            string cnp = "", nume = "", id = "";
        //            while (await reader.ReadAsync())
        //            {
        //                cnp = reader.GetString("CNP");
        //                nume = reader.GetString("NUME");
        //                id = reader.GetString("ID_STUDENT");

        //            }
        //            return "Cnp: " + cnp + " Nume: " + nume + " id: " + id;
        //        }
        //        return null;
                
        //    }
        //    catch(Exception e)
        //    {
        //        return e.Message;
        //    }
        //}

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

            try {
                MySqlConnection connection = MyConnection.getConnection().Result;
                using MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM utilizatori " +
                    "WHERE username = @username AND password = @password ";
                command.Parameters.AddWithValue("@username", u.username);
                command.Parameters.AddWithValue("@password", u.password);

                MySqlDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows) {
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

        [HttpPost("/studenti/facultate")]
        public async Task<ActionResult> CitireDateStudent([FromBody]Student s)
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

            }catch(SqlException e)
            {
                _logger.LogError(e, "A aparut o eroare in timpul conexiunii la baza de date");
                return StatusCode(500);
            }

        }

        [HttpPost("/studenti/facultate/burse/alocate")]
        public async Task<ActionResult> AcordareBurse([FromBody]Student s)
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
            int[] idStudenti = {10,12,23,14};
            string tipBursa = "Buget";
            int rowsAffected = 0;

            try {
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
                return Ok( rowsAffected + "rows affected");
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

            try {
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

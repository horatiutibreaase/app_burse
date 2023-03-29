using MySqlConnector;
using System;

namespace backend_1.Controllers
{

    public class MyConnection
    {
        static MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;User ID=root;Password=Alexovidiu2003;Database=test");
        public static async Task<MySqlConnection> getConnection()
        {
            try
            {
                await connection.OpenAsync();
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Couldn't connect to database");
            }

            return null;
        }

    }

}

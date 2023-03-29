using MySqlConnector;
using System;

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

    public static async Task<MySqlDataReader> getReader(string query) {
        try
        {
            await connection.OpenAsync();
            using MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = await command.ExecuteReaderAsync();

            return reader;
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return null;
    }
}

using System;
using MySql.Data.MySqlClient;

namespace Day31_db
{
    class Program
    {
        static void Main(string[] args)
        {
            Connect();
        }

        static void Connect()
        {
            var settings = new MySqlConnectionStringBuilder
            {
                Server = "178.128.47.243",
                UserID = "root",
                Password = "danger123",
                Port = 3306,
                Database = "Books"
            };


            try
            {
                MySqlConnection conn = new MySqlConnection(settings.ConnectionString);
                conn.Open();

                Console.WriteLine("Connection successful");
            }
            catch
            {
                Console.WriteLine("Connection failed!");

            }


        }
    }
}

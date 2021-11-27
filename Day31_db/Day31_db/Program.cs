using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Day31_db
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Author> lst = Connect();
            
            foreach(Author a in lst)
            {
                Console.WriteLine(a.AuthorLastName);
            }
        }

        static List<Author> Connect()
        {
            List<Author> local = new List<Author>();
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

                String readCommand = "SELECT AuthorName, AuthorLastname FROM Books.Authors;";

                MySqlCommand m = new MySqlCommand(readCommand, conn);
                MySqlDataReader dataReader = m.ExecuteReader();

                while (dataReader.Read())
                {

                    Author localObj = new Author();
                    localObj.AuthorName = dataReader["AuthorName"].ToString();
                    localObj.AuthorLastName = dataReader["AuthorLastName"].ToString();

                    local.Add(localObj);
                }

                dataReader.Close();
                conn.Close();
                
            }
            catch
            {
                Console.WriteLine("Connection failed!");
                
            }

            return local;
        }
    }
}

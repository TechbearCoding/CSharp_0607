using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day31_db
{
    class Queries
    {
        public static void InsertAuthor(String firstName, String LastName, Connection conn)
        {
            try
            {
                conn.Open();
                MySqlCommand insert = conn.GetConnetion().CreateCommand();
                insert.CommandText = "INSERT INTO Authors(AuthorName, AuthorLastName) VALUES(@name, @lastName)";
                insert.Parameters.AddWithValue("@name", firstName);
                insert.Parameters.AddWithValue("@lastName", LastName);
                insert.ExecuteNonQuery();

                conn.Close();
            }
            catch
            {
                Console.WriteLine("Connection failed!");
            }
        }
        public static List<Author> SelectAuthors(Connection conn)
        {
            List<Author> local = new List<Author>();

            try
            {
                conn.Open();
                String readCommand = "SELECT AuthorName, AuthorLastname FROM Books.Authors;";

                MySqlCommand m = new MySqlCommand(readCommand, conn.GetConnetion());
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

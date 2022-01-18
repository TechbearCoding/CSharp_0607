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


        public static void DeleteAuthor(int id, Connection conn)
        {
            try
            {
                conn.Open();
                MySqlCommand delete = conn.GetConnetion().CreateCommand();

                delete.CommandText = "DELETE FROM Authors WHERE AuthorId = @id";
                delete.Parameters.AddWithValue("@id", id);

                delete.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection failed!");
                Console.WriteLine(ex.Message);
            }

        }
        public static List<Author> SelectAuthors(Connection conn)
        {
            List<Author> local = new List<Author>();

            try
            {
                conn.Open();
                String readCommand = "SELECT AuthorId, AuthorName, AuthorLastname FROM Books.Authors;";

                MySqlCommand m = new MySqlCommand(readCommand, conn.GetConnetion());

                MySqlDataReader dataReader = m.ExecuteReader();

                while (dataReader.Read())
                {

                    Author author = new Author();

                    author.Id = dataReader.GetInt32("AuthorId");
                    author.AuthorName = dataReader.GetString("AuthorName");
                    author.AuthorLastName = dataReader.GetString("AuthorLastName");

                    local.Add(author);
                }

                dataReader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection failed!");
                Console.WriteLine(ex.Message);
            }

            return local;
        }
    }
}

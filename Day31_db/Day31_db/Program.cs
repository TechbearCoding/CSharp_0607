using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Day31_db
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection connection = new Connection();

            /*List<Author> lst = Queries.SelectAuthors(connection);
            
            foreach(Author a in lst)
            {
                Console.WriteLine(a.AuthorLastName);
            }*/

            Queries.InsertAuthor("Juris", "Kļava", connection);
        }
    }
}

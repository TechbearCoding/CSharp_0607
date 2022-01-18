using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Day31_db
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection connection = new Connection();
            //Queries.InsertAuthor("Juris", "Kļava", connection);
            //Queries.DeleteAuthor(6, connection);

            List<Author> lst = Queries.SelectAuthors(connection);
            
            /*foreach(Author a in lst)
            {
                Console.WriteLine(a.AuthorName + " " + a.AuthorLastName);
            }*/

            //serialize
            String AuthorJson = JsonSerializer.Serialize(lst);
            Console.WriteLine(AuthorJson);

            
            //deserialize
            List<Author> lst2 = JsonSerializer.Deserialize<List<Author>>(AuthorJson);
            foreach(Author a in lst)
            {
                Console.WriteLine(a.AuthorName + " " + a.AuthorLastName);
            }


        }
    }
}

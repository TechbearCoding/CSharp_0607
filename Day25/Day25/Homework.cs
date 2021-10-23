using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Day25
{
    class Homework
    {

        public static void Rakstitajs()
        {
            String fileName = "sample1.txt";
            try
            {
                User user = new User();

                Console.WriteLine("Lietotaja Vards");
                string userName = Console.ReadLine();

                Console.WriteLine("Lietotaja parole");
                string passWord = Console.ReadLine();

                Console.WriteLine("Vards?");
                string name = Console.ReadLine();

                Console.WriteLine("Uzvards?");
                string lastName = Console.ReadLine();

                Console.WriteLine("Gads?");
                int year = Convert.ToInt32(Console.ReadLine());

                user.InitUser(userName, passWord, name, lastName, year);
                String jsonString = JsonSerializer.Serialize(user);

                Console.WriteLine(jsonString);

                StreamWriter writer = new StreamWriter(fileName);

                writer.WriteLine(jsonString);

                writer.Close();
            }
            catch
            {
                Console.WriteLine("Error!");
            }

        }

        public static void Lasitajs()
        {

            String fileName = "sample1.txt";
            try
            {
                StreamReader reader = new StreamReader(fileName);
                String a = reader.ReadToEnd();
                reader.Close();
                User user = JsonSerializer.Deserialize<User>(a);
                Console.WriteLine(user.userName);
            }
            catch
            {
                Console.WriteLine("Error!");
            }
        }
    }
}

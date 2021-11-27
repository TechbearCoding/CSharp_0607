using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Day25
{
    class Program
    {

        public static List<string> stringList = new List<string>();
        static String folderPath = @"C:\Users\Martins Leitarts\Desktop\";
        static void Main(string[] args)
        {
            Iedave();
            Izvade();
        }

        static void Iedave()
        {

            String fileName = folderPath + "string.txt";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadi stringu");
                string ievade = Console.ReadLine();
                stringList.Add(ievade);
            }


            String jsonString = JsonSerializer.Serialize(stringList);

            Console.WriteLine(jsonString);

            StreamWriter writer = new StreamWriter(fileName);

            writer.WriteLine(jsonString);

            writer.Close();

        }

        static void Izvade()
        {
            String fileName = folderPath + "string.txt";

            StreamReader reader = new StreamReader(fileName);

            String a = reader.ReadToEnd();

            reader.Close();

            List<String> stringList = JsonSerializer.Deserialize<List<String>>(a);

            for (int i = 0; i < stringList.Count; i++)
            {
                Console.WriteLine(stringList[i]);
            }
        }

        static void Sample()
        {
            //Homework.Rakstitajs();
            List<User> lstUsr = new List<User>();
            lstUsr.Add(new User());
            lstUsr[0].InitUser("user", "user", "user", "user", 2011);

            lstUsr.Add(new User());
            lstUsr[1].InitUser("user2", "user2", "user2", "user2", 2012);

            String jsonString = JsonSerializer.Serialize(lstUsr);
            Console.WriteLine(jsonString);


            List<User> lstUsr2 = JsonSerializer.Deserialize<List<User>>(jsonString);

            Console.WriteLine(lstUsr2[0].name);
        }
    }
}

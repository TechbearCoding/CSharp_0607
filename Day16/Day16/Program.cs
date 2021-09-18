using System;
using System.Collections.Generic;

namespace Day16
{
    class Program
    {
        static List<int> gen = new List<int>();
        static List<int> user = new List<int>();
        static void Main(string[] args)
        {

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ievadiet skaitli!");
                user.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                gen.Add(rand.Next(0, 11));
                Console.Write(gen[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < user.Count; i++)
            {
                bool check = IsNumberThere(user[i]);
                if (check == false)
                {
                    Console.WriteLine("Kluda!!!");
                    return;
                }
            }

            Console.WriteLine("OK!!!");
        }


        static bool IsNumberThere(int number)
        {
            for (int j = 0; j < gen.Count; j++)
            {
                if (gen[j] == number)
                {
                    return true;
                }
            }
            return false;
        }

    }
}

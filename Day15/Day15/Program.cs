using System;
using System.Collections.Generic;

namespace Day15
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<int> saraksts = new List<int>();

            int randomnumber = 0;
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 30; i++)
            {
                randomnumber = random.Next(0, 11);

                saraksts.Add(randomnumber);

                Console.Write(saraksts[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < 30; i++)
            {
                //Console.WriteLine(saraksts[i]);

                if (saraksts[i] == input)
                {
                    Console.WriteLine(i);
                }
            }

            for (int i = 30; i >= 0; i--)
            {

            }

        }
    }
}

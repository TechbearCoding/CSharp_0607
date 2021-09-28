using System;
using System.Collections.Generic;

namespace Day17
{
    class Program
    {
        static List<String> elements = new List<String>();
        static void Main(string[] args)
        {
            InitList();
            WriteList();

            Console.WriteLine("1. Izvadīt simbolu skaitu lista elementā");
            Console.WriteLine("2. Izvadīt vidējo garumu no visiem elementiem");
            Console.WriteLine("3. Izvadīt visu elementu garumu summu");

            int choice;
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error! Choice = 1");
                choice = 1;
            }
            

            switch (choice)
            {
                case 1:
                    DisplayLen();
                    break;
                case 2:
                    Console.WriteLine(SumLen()/elements.Count);
                    break;
                case 3:
                    Console.WriteLine(SumLen());
                    break;
                default:
                    return;
            }
        }

        private static Double SumLen()
        {
            int sum = 0;
            for(int i = 0; i < elements.Count; i++)
            {
                sum += elements[i].Length;
            }
            return sum;
        }

        static void DisplayLen()
        {
            WriteList();

            Console.WriteLine("Kura elementu garumu izvadīt?");
            int choice;
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Elementa garums- " + elements[choice].Length);
            }
            catch
            {
                Console.WriteLine("Error!");
            }
        }

        static void InitList()
        {
            Console.WriteLine("Izvēlaties, cik elementus ievadīt");

            int count = Convert.ToInt32(Console.ReadLine());


            if (count < 1)
            {
                count = 5;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Ievadiet elementu");

                String ievade = Console.ReadLine();

                elements.Add(ievade);
            }
        }

        static void WriteList()
        {
            Console.WriteLine();

            for (int i = 0; i < elements.Count; i++)
            {
                Console.WriteLine(i + ") " + elements[i]);
            }

            Console.WriteLine();
        }

    }


}

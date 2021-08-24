﻿using System;

namespace Day9_BackToSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenNumber());
        }

        static int GenNumber()
        {
            Console.WriteLine("ja geribi generet  spied 'y' ");

            string input = Console.ReadLine();

            if (input == "y")
            {
                Random random = new Random();

                int Randomkaitlis = random.Next(1, 11);

                return Randomkaitlis;
            }

            else
            {
                return 0;
            }
        }

        static void Task2(int times)
        {
            for(int i = 0; i < times; i++)
            {
                Console.WriteLine("#####");
            }
        }

        static void Task1()
        {
            Console.WriteLine("Ievadiet skaitli!");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i < 10; i++)
            {
                int result = i * number;

                Console.WriteLine(number + " * " + i + " = " + result);
            }
        }


        static void Poetry()
        {
            Console.WriteLine("Ka gulbji balti padebesi iet");
            Console.WriteLine("Gribetos vel tiem lidzi talu skriet");
        }
    }
}

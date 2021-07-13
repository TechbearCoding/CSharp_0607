using System;

namespace Day3_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum(1,2);
            Sum(8, 99);

            int a = 6;
            Sum(1, a);
        }

        static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Piemers1()
        {
            Console.WriteLine("Ievadiet 1. skaitli!");
            String input = Console.ReadLine();

            int skaitlis = Convert.ToInt32(input);

            Console.WriteLine("Ievadiet 2. skaitli!");
            input = Console.ReadLine();

            int skaitlis2 = Convert.ToInt32(input);
            Console.WriteLine("Summa ir " + (skaitlis + skaitlis2));
        }
    }
}

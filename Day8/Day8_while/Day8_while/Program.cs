using System;

namespace Day8_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzdevums1();
        }

        static void Uzdevums1()
        {
            int sum = 0;

            String choice = "";

            while(choice != "exit")
            {
                Console.WriteLine("Ievadiet skaitli!");
                int sk = Convert.ToInt32(Console.ReadLine());

                sum = sum + sk;

                Console.WriteLine("Vai velaties turpinat darbu?");
                choice = Console.ReadLine();

            }
            
            Console.WriteLine(sum);
        }
    }
}

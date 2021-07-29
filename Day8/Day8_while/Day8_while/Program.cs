using System;

namespace Day8_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzdevums2();
        }

        static void Uzdevums2()
        {
            String choice = "";
            int counter = 1;

            while (choice != "exit")
            {
                Console.WriteLine("iteracija: " + counter);
                counter++;

                Console.WriteLine("Vai velaties turpinat darbu?");
                choice = Console.ReadLine();
            }
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

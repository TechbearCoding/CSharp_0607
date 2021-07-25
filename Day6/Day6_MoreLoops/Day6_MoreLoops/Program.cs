using System;

namespace Day6_MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzdevums3();
        }

        static void Uzdevums3()
        {
            int biggest = 0;
            for(int i = 0; i < 5; i++)
            {
                int current = NumberInput();

                if (current > biggest)
                {
                    biggest = current;
                }
            }

            Console.WriteLine("Lielakais skaitlis ir " + biggest);
        }


        static void Uzdevums2()
        {
            Console.WriteLine("Ievadiet skaitli!");
            int fakt = Convert.ToInt32(Console.ReadLine());

            int result = 1;
            Console.Write(result);
            for (int i = 2; i <= fakt; i++)
            {
                Console.Write("*" + i);
                result = result * i;
            }

            Console.WriteLine(" = " + result);
        }

        static void Uzdevums1()
        {
            int wins = 0;

            for(int i = 0; i < 5; i++) { 
                Random random = new Random();

                int randomNumber = random.Next(1, 11);

                int guess = NumberInput();

                if (randomNumber == guess)
                {
                    Console.WriteLine("Spele ir uzvareta!");
                    wins++; //wins = wins + 1
                }
                else
                {
                    Console.WriteLine("Spele zaudeta, istais skaitlis ir " + randomNumber);
                }
            }

            Console.WriteLine("Uzvaras- " + wins);
            Console.WriteLine("Zaudejumi- " + (5 - wins));

        }

        static int NumberInput()
        {
            Console.WriteLine("Ievadiet skaitli!");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}

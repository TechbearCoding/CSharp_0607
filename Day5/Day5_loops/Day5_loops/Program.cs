using System;

namespace Day5_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //LoopSample3();
            Uzdevums3();

        }

        static void Uzdevums3()
        {
            String stars = ""; 

            for(int i = 0; i < 5; i++)
            {
                stars = stars + "*";
                Console.WriteLine(stars);
            }

        }

        static void LoopSample3()
        {
            //Saskaitīt un izvadīt skaitļus no 1-10
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            

            Console.WriteLine(sum);
        }


        static void LoopSample2()
        {
            int sum = 0;
           
            for(int i = 0; i < 5; i++)
            {
                sum = i;
            }

            Console.WriteLine(sum);
        }

        static void LoopSample1()
        {
            //for, while, do..while

            for (int i = 0; i < 10; i++)
            {
                //i++    i=i+1
                Console.WriteLine(i);
                Console.WriteLine("Hello world!");
            }
            
        }

        static void Uzdevums1()
        {
            Random random = new Random();

            int randomNumber = random.Next(1, 11);

            int guess = NumberInput();

            if (randomNumber == guess)
            {
                Console.WriteLine("Spele ir uzvareta!");
            }
            else
            {
                Console.WriteLine("Spele zaudeta, istais skaitlis ir " + randomNumber);
            }
        }


        static int NumberInput()
        {
            Console.WriteLine("Ievadiet skaitli!");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}

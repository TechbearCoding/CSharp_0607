using System;

namespace Day7_EvenMoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Kapinasana();
        }


        static void Kapinasana()
        {
            int baze = NumberInput("Ievadiet bazi!");
            int pakape = NumberInput("Ievadiet pakapi!");

            int result = 1;

            for(int i = 0; i < pakape; i++)
            {
                result = result * baze;
            }

            Console.WriteLine(result);
        }

        
        static int NumberInput(String text)
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}

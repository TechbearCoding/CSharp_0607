using System;

namespace Day7_EvenMoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Piemers1();
        }


        static void Uzdevums2()
        {

        }

        static void Piemers3()
        {
            while (true)
            {
                Console.WriteLine("Hello!");
                String choice = Console.ReadLine();

                if(choice == "exit")
                {
                    break;
                }
            }
        }

        static void Piemers2()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

        }


        static void Piemers1()
        {
            String choice = "";
            while (choice != "EXIT")
            {
                Console.WriteLine("Hello!");

                Console.WriteLine("Rakstat EXIT, lai izietu, jebko citu, lai turpinatu!");
                choice = Console.ReadLine();
            }

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

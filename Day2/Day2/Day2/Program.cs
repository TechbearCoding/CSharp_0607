using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Piemers3();

            String a = "aaaaa";

            int b = a.Length;

            Console.WriteLine(a.Length);
            //vai ari
            Console.WriteLine(b);
        }

        static void Piemers3()
        {
            Console.WriteLine("Ievadiet vecumu!");
            String input = Console.ReadLine();
            int age = Convert.ToInt32(input);

            if(age > 17)
            {
                Console.WriteLine("Lietotajs ir pilngadigs!");
            }
            else
            {
                Console.WriteLine("Lietotajam vel nav 18!");
            }
        }

        static void Piemers2()
        {
            // ==
            // !=
            // >
            // <
            // <=
            // >=

            Console.WriteLine("Ievadiet paroli!");  
            String psw = Console.ReadLine();

            if(psw == "1234")
            {
                Console.WriteLine("Parole ir pareiza!");
            }
            else
            {
                Console.WriteLine("Parole ir nepareiza!");
            }

        }

        static void Uzdevums1()
        {
            Console.WriteLine("Ievadiet 1. skaitli!");
            String input = Console.ReadLine();
            //input = "16"

            int number1 = Convert.ToInt32(input);
            //input = "16"
            //number1 = 16

            Console.WriteLine("Ievadiet 2. skaitli!");
            input = Console.ReadLine();
            //input = 4
            //number1 = 16

            int number2 = Convert.ToInt32(input);
            //input = 4
            //number1 = 16
            //number2 = 4
            Console.WriteLine(number1 + number2);
            Console.WriteLine(number1 - number2);

            //int number2 = Convert.ToInt32(Console.ReadLine());
        }

        static void Piemers()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String inputNumber = Console.ReadLine();

            int number = Convert.ToInt32(inputNumber);
            Console.WriteLine(number);
            //------------------

            String a = "3";
            int b = Convert.ToInt32(a);

            //------------------
        }
    }
}

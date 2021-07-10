using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzdevums5();
        }

        static void Uzdevums5()
        {
            Console.WriteLine("Ievadiet 1. skaitli!");
            String input = Console.ReadLine();

            int number1 = Convert.ToInt32(input);

            Console.WriteLine("Ievadiet 2. skaitli!");
            input = Console.ReadLine();

            int number2 = Convert.ToInt32(input);

            Console.WriteLine("Ievadiet + vai -");
            input = Console.ReadLine();

            if(input == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            else if(input == "-")
            {
                Console.WriteLine(number1 - number2);
            }
            else
            {
                Console.WriteLine("Ievades kluda!");
            }

            
            
        }

        static void Piemers5()
        {
            // && -> Un
            // || -> Vai

            //Parbaudit vai skaitlis ir no 1..18
            //ja ir diapazona, izvadit True
            //ja nav izvadit False

            Console.WriteLine("Ievadiet vecumu!");
            String input = Console.ReadLine();
            int age = Convert.ToInt32(input);

            if (age > 0 && age < 19)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static void Piemers4()
        {
            Console.WriteLine("Ievadiet vecumu!");
            String input = Console.ReadLine();
            int age = Convert.ToInt32(input);

            if (age > 17)
            {
                Console.WriteLine("Lietotajs ir pilngadigs!");
            }
            else if(age < 0)
            {
                Console.WriteLine("Jaievada skaitlis sakot ar 0.");
            }
            else
            {
                Console.WriteLine("Lietotajam vel nav 18!");
            }
        }

        static void Uzdevums3()
        {
            Console.WriteLine("Ievadiet simbolu virkni!");
            String virkne1 = Console.ReadLine();

            Console.WriteLine("Ievadiet 2. simbolu virkni!");
            String virkne2 = Console.ReadLine();

            int kopejaisGarums = virkne1.Length + virkne2.Length;

            if(kopejaisGarums > 10)
            {
                Console.WriteLine(virkne1 + "...");
            }
            else
            {
                Console.WriteLine(virkne1 + virkne2);
            }
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
            // == - vienads
            // != - nav vienads
            // > - lielaks
            // < - mazaks
            // <= - lielaks/vienads
            // >= - mazaks/vienads

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

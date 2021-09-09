using System;

namespace Day13_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            String choice = "";

            while(choice != "0")
            {
                Console.WriteLine("1- Sum");
                Console.WriteLine("2- Sub");
                Console.WriteLine("3- Multi");
                Console.WriteLine("4- Div");
                Console.WriteLine("0- Exit\n");

                choice = Console.ReadLine();
                if(choice == "0")
                {
                    break;
                }

                Console.WriteLine("Ievadiet 1. skaitli!");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ievadiet 2. skaitli!");
                double b = Convert.ToDouble(Console.ReadLine());

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Rezultats = " + SimpleMath.Sum(a,b));
                        break;
                    case "2":
                        Console.WriteLine("Rezultats = " + SimpleMath.Sub(a, b));
                        break;
                    case "3":
                        Console.WriteLine("Rezultats = " + SimpleMath.Multi(a, b));
                        break;
                    case "4":
                        Console.WriteLine("Rezultats = " + SimpleMath.Div(a, b));
                        break;
                    default:
                        Console.WriteLine("Jaievada 1, 2, 3, 4 vai 0, lai izveletos");
                        break;
                }
            }
        }
    }
}

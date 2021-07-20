using System;

namespace Day4_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = NameInput();
            Console.WriteLine(a);

            String b = NameInput();
            Console.WriteLine(b);
        }


        static String NameInput()
        {
            Console.WriteLine("Ievadiet cilvēka vārdu!");
            String name = Console.ReadLine();

            if(name.Length > 5)
            {
                return name;
            }
            else
            {
                return "empty";
            }

        }

        static int SkaitlaIevade()
        {
            Console.WriteLine("Ievadiet skaitli!");
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            return skaitlis;
        }


        static int Sum(int a, int b)
        {
            int c = a + b;
            return c;
        }





        static void Complete(string a, string b, string c)
        {
            Console.WriteLine(a + b + c);

            int totalsize = a.Length + b.Length + c.Length;

            Console.WriteLine(totalsize);

        }

        static void Darbibas(int a)
        {
            int skaitlis = SkaitlaIevade();

            int skaitlis2 = SkaitlaIevade();

            if (a == 1)
            {
                Console.WriteLine(skaitlis2 + skaitlis);
            }else if (a == 2)
            {
                Console.WriteLine(skaitlis - skaitlis2);
            }else if (a == 3)
            {
                Console.WriteLine(skaitlis * skaitlis2);
            }
            else
            {
                Console.WriteLine("Skaitlim vajadzeja but no 1 lidz 3");
            }
        }
    }
}

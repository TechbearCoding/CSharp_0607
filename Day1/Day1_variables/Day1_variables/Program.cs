using System;

namespace Day1_variables
{
    class Program
    {

        static void Main(string[] args)
        {
            String pirmaisJautajums = "1. Ka Jus sauc?";
            Console.WriteLine(pirmaisJautajums);
            String ievade;
            ievade = Console.ReadLine();
            Console.WriteLine(ievade);

            Console.WriteLine("2. No kurienes Jus esat?");
            String ievade2 = Console.ReadLine();
            Console.WriteLine(ievade2);

            Console.WriteLine("Cilveks " + ievade + " ir no " + ievade2);
        }

        static void piemers2()
        {
            //Izvade
            int a = 3;
            a = 3 + 2;

            Console.WriteLine("aaaaa");
            Console.WriteLine(a + 3);
            Console.WriteLine(a);

            String b = "aa";
            String c = "cc";

            Console.WriteLine(b + " " + c);

            //Ievade
            String ievade = Console.ReadLine();
            Console.WriteLine(ievade);
        }

        static void piemers1()
        {
            //---------------
            //mainigo tipi
            int a = 3;  //vesels skaitlis (no anglu val.- Integer)

            a = 5;

            uint b = 3; //ari vesels skaitlis, bet nevar but negativas vertibas

            double c = 3.4; //skaitlis ar komatu (vel ir ari float)
            String d = "Simbolu virkne";

            bool e = true; //true vai false
            char f = 'a'; //Viens simbols

            Console.WriteLine("Si ir teksta izvade");
            //---------------

            String ievade;

            Console.WriteLine("Ievadiet demo tekstu!");
            ievade = Console.ReadLine();

            Console.WriteLine(ievade); //ja mes izvadam mainigo- nosaukums nav jaliek pedinas

            Console.WriteLine(1 + 3);
            Console.WriteLine(d + "def");
        }

    }
}

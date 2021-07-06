using System;

namespace Day1_variables
{
    class Program
    {

        static void Main(string[] args)
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

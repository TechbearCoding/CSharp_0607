using System;

namespace Day9_BackToSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = -1;
            int sum = 0;

            int dealerSum = 0;
            Random rnd = new Random();

            while (number != 0)
            {
                
                number = GenNumber();
                if(number == 0)
                {
                    break;
                }
                sum = sum + number;

                dealerSum += rnd.Next(1, 11);

                Console.WriteLine("Pasreizeja summa ir " + sum);
                Console.WriteLine("Dileris- " + dealerSum);

                if (sum > 21)
                {
                    break;
                }

                if(dealerSum > 21)
                {
                    break;
                }

            }

            if ( sum > 21 || dealerSum > sum && dealerSum < 22)
            {
                Console.WriteLine("Dileris uzvar");
            }else if(dealerSum > 21 || dealerSum < sum && sum < 22)
            {
                Console.WriteLine("Speletajs uzvar");
            }
            else
            {
                Console.WriteLine("Neizskirts!");
            }

            Console.WriteLine("Summa ir " + sum);
        }

        static int GenNumber()
        {
            Console.WriteLine("Ja gribi generet  spied 'y' ");

            string input = Console.ReadLine();

            if (input == "y")
            {
                Random random = new Random();

                int Randomkaitlis = random.Next(1, 11);

                return Randomkaitlis;
            }

            else
            {
                return 0;
            }
        }

        static void Task2(int times)
        {
            for(int i = 0; i < times; i++)
            {
                Console.WriteLine("#####");
            }
        }

        static void Task1()
        {
            Console.WriteLine("Ievadiet skaitli!");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i < 10; i++)
            {
                int result = i * number;

                Console.WriteLine(number + " * " + i + " = " + result);
            }
        }


        static void Poetry()
        {
            Console.WriteLine("Ka gulbji balti padebesi iet");
            Console.WriteLine("Gribetos vel tiem lidzi talu skriet");
        }
    }
}

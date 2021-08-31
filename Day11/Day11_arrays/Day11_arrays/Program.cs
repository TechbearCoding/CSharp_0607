using System;

namespace Day11_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzdevums2();
        }

        static void Uzdevums2()
        {
            Console.WriteLine("Ievadiet masiva garumu!");
            int len = Convert.ToInt32(Console.ReadLine());

            String[] arrayOfStrings = new String[len];

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Ievadiet " + i + ". vertibu!");
                arrayOfStrings[i] = Console.ReadLine();
            }
            Console.WriteLine();

            for (int i = 0; i < len; i++)
            {
                Console.Write(arrayOfStrings[i] + " ");
            }

        }

        static void Piemers1()
        {
            int[] testArray = new int[5];

            testArray[0] = 2;
            testArray[1] = 4;

            testArray[2] = 32;
            testArray[3] = 6;

            testArray[4] = 91;

            for(int i = 0; i < testArray.Length; i++)
                Console.WriteLine(testArray[i]);

            String[] testString = { "aa", "bb", "cc", "aa1" };

            Console.WriteLine();

            for (int i = 0; i < testString.Length; i++)
                Console.WriteLine(testString[i]);

        }
    }
}

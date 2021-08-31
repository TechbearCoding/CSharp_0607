using System;

namespace Day11_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Piemers1();
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

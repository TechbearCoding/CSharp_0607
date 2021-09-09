using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_lists
{
    class Samples2
    {
        public static int c = 2;
        private static int d = 3;
        public static void SampleOutput()
        {
            Console.WriteLine("Hello world!");
            PrivateOutput();
        }

        public static int SampleSum(int a, int b) 
        {
            return a + b;
        }

        private static void PrivateOutput()
        {
            Console.WriteLine("Hello private world!");
        }
    }
}

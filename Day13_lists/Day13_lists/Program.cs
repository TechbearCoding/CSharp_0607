using System;
using System.Collections.Generic;

namespace Day13_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Piemers();
        }

        static void Piemers()
        {
            List<String> a = new List<String>();
            a.Add("aa");
            a.Add("bb");

            for(int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }

            a.RemoveAt(0);


            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}

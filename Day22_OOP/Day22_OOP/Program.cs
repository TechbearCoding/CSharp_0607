using System;

namespace Day22_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Jānis", "Bērziņš", 1993, 9.6);
            s1.Print();

            Student s2 = new Student("Juris", "Ābols", 1991, 7.1);
            s2.Print();
        }
    }
}

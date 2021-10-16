using System;

namespace Day23_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Jānis", "Bērziņš", 1993, 9.6);
            s1.Print();

            s1.name = "Juris";
            s1.SetYear(1950);
            s1.lastName = "Ābols";
        }
    }
}

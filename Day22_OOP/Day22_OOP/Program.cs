using System;
using System.Collections.Generic;

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

            List<Student> stList = new List<Student>();
            Console.WriteLine("--------------------------");
            stList.Add(s1);
            stList.Add(s2);
            stList.Add(new Student("Aldis", "Ābols", 1996, 7.9));

            for(int i = 0; i < stList.Count; i++)
            {
                stList[i].Print();
            }

            Console.WriteLine();

            foreach(Student fluffy in stList)
            {
                fluffy.Print();
            }
        }
    }
}

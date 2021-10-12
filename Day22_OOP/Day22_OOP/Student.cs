using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22_OOP
{
    class Student
    {
        public String name;
        public String lastName;
        public int year;
        public double avarage;

        public Student(String name, String lastName, int year, double avarage)
        {
            this.name = name;
            this.lastName = lastName;
            this.year = year;
            this.avarage = avarage;
        }

        public void Print()
        {
            Console.WriteLine(name + " " + lastName);
            Console.WriteLine("Year- " + year);
            Console.WriteLine("Avarage- " + avarage);
        }
    }
}

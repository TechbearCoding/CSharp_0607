using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24_json
{
    class Student
    {
        public String name { get; set; }
        public String lastName { get; set; }
        public int year { get; set; }

        public void InitStudent(String name, String lastName, int year)
        {
            this.name = name;
            this.lastName = lastName;
            this.year = year;
        }

        public void Print()
        {
            Console.WriteLine(name + " " + lastName);
            Console.WriteLine("Year- " + year);
        }
    }
}

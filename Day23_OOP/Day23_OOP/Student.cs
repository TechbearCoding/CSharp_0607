using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23_OOP
{
    class Student
    {
        private String _name;
        public String name
        {
            get
            {
                return _name;
            }

            set
            {
                if (value.Length > 10) 
                {
                    _name = "default";
                }
                else
                {
                     _name = value;
                }
            }
        }
        public String lastName { get; set; }
        private int year;
        public double avarage { get; set; }

        public Student(String name, String lastName, int year, double avarage)
        {
            this.name = name;
            this.lastName = lastName;
            SetYear(year);
            this.avarage = avarage;
        }

        public int GetYear()
        {
            return year;
        }

        public void SetYear(int year)
        {
            if(year > DateTime.Now.Year)
            {
                this.year = DateTime.Now.Year;
            }else if(year < 1920)
            {
                this.year = 1920;
            }
            else
            {
                this.year = year;
            }
            
        }

        public void Print()
        {
            Console.WriteLine(name + " " + lastName);
            Console.WriteLine("Year- " + year);
            Console.WriteLine("Avarage- " + avarage);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23_OOP
{
    class Triangle
    {
        private double _malaA;
        private double _malaB;
        private double _malaC;
        public double malaA
        {
            get
            {
                return _malaA;
            }

            set
            {
                if(CheckIfExists(value, malaB, malaC))
                {
                    _malaA = value;
                }
                else
                {
                    _malaA = 0;
                    _malaB = 0;
                    _malaC = 0;
                    Console.WriteLine("Kļūda");
                }
            }
        }
        public double malaB
        {
            get
            {
                return _malaB;
            }

            set
            {
                if (CheckIfExists(malaA, value, malaC))
                {
                    _malaB = value;
                }
                else
                {
                    _malaA = 0;
                    _malaB = 0;
                    _malaC = 0;
                    Console.WriteLine("Kļūda");
                }
            }
        }
        public double malaC
        {
            get
            {
                return _malaC;
            }

            set
            {
                if (CheckIfExists(malaA, malaB, value))
                {
                    _malaC = value;
                }
                else
                {
                    _malaA = 0;
                    _malaB = 0;
                    _malaC = 0;
                    Console.WriteLine("Kļūda");
                }
            }
        }

        public Triangle(double malaA, double malaB, double malaC)
        {
            _malaA = malaA;
            _malaB = malaB;
            _malaC = malaC;

            if (!CheckIfExists(malaA, malaB, malaC))
            {
                _malaA = 0;
                _malaB = 0;
                _malaC = 0;
                Console.WriteLine("Kļūda");
            }
        }

        public double GetPer()
        {
            return malaA + malaB + malaC;
        }

        public bool CheckIfExists(double a, double b, double c)
        {
            if(a + b > c && 
                b + b > c && 
                a + c > b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

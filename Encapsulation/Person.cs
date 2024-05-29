using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    internal class Person
    {
        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                    _age = value;
                else throw new ArgumentException("Age cannot be less than zero.");
            }
        }

        private string _fName;

        public string FName
        {
            get { return _fName; }
            set
            {
                if (CheckStringLengthValidity("FName", value, 2, 10))
                    _fName = value;
            }
        }

        private string _lName;

        public string LName
        {
            get { return _lName; }
            set { _lName = value; }
        }

        private double _height;

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        private double _weight;

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public Person(string fName, string lName)
        {
            FName = fName;
            LName = lName;
        }

        private bool CheckStringLengthValidity(string prop, string str, int min, int max)
        {
            if (str.Length < min)
                throw new ArgumentException($"{prop} must be longer than {min - 1} character.");
            else if (str.Length > max)
                throw new ArgumentException($"{prop} must be shorter than {max + 1} characters.");
            else return true;
        }
    }
}

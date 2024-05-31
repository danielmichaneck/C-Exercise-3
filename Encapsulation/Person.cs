using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    /// <summary>
    /// A class containing information about a person.
    /// </summary>
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
                if (CheckStringNullLengthValidity("FName", value) &&
                    CheckStringLengthValidity("FName", value, 2, 10))
                    _fName = value;
            }
        }

        private string _lName;

        public string LName
        {
            get { return _lName; }
            set
            {
                if (CheckStringNullLengthValidity("LName", value) &&
                    CheckStringLengthValidity("LName", value, 2, 10))
                    _lName = value;
            }
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

        public Person(string fullName)
        {
            string[] names = fullName.Split(" ");
            FName = names[0];
            LName = names[1];
        }

        /// <summary>
        /// Checks if a string is a valid input.
        /// </summary>
        /// <param name="prop"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private bool CheckStringNullLengthValidity(string prop, string str)
        {
            if (String.IsNullOrWhiteSpace(str))
                throw new ArgumentException($"{prop} was null, empty, or white space.");
            else return true;
        }

        /// <summary>
        /// Checks if a string is of a valid length.
        /// </summary>
        /// <param name="prop"></param>
        /// <param name="str"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
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

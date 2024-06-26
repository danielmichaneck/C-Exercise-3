﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests")]

namespace Persons
{
    /// <summary>
    /// Creates and edits Person instances.
    /// </summary>
    internal class PersonHandler
    {
        /// <summary>
        /// Creates a Person instance with the values in the parameter.
        /// </summary>
        /// <param name="age"></param>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new(fname, lname);
            person.Age = age;
            person.Height = height;
            person.Weight = weight;
            return person;
        }

        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }

        public void SetName(Person person, string name)
        {
            string[] names = name.Split(" ");
            person.FName = names[0];
            person.LName = names[1];
        }

        public void SetHeight(Person person, double height)
        {
            person.Height = height;
        }

        public void SetWeight(Person person, double weight)
        {
            person.Weight = weight;
        }

        public void DoNothing()
        {
            throw new ArgumentException("For the test!");
        }
    }
}

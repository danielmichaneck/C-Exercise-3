using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// An abstract base class for animals.
    /// </summary>
    internal abstract class Animal
    {
        private string _name = "Animal";

        public string Name { get; set; }

        private double _weight;

        public double Weight { get; set; }

        private int _age;

        public int Age { get; set; }

        protected Animal() { }

        /// <summary>
        /// Returns the animal's properties
        /// as a string.
        /// </summary>
        /// <returns></returns>
        public abstract string Stats();

        /// <summary>
        /// Prints a sound that the animal
        /// makes in the console.
        /// </summary>
        internal abstract void DoSound();
    }
}

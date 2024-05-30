using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class Animal
    {
        private string _name;

        public string Name { get; set; }

        private double _weight;

        public double Weight { get; set; }

        private int _age;

        public int Age { get; set; }

        protected Animal()
        {

        }
        internal abstract void DoSound();
    }
}

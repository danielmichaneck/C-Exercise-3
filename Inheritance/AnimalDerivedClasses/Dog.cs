using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Dog : Animal
    {
        protected const bool IsGoodBoy = true;

        private double _speed;

        public double Speed {
            get { return _speed; }
            set { _speed = value; } }

        public override string Stats()
        {
            throw new NotImplementedException();
        }

        internal override void DoSound()
        {
            Console.WriteLine("Woof woof!");
        }
    }
}

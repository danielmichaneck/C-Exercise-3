using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Horse : Animal
    {
        private double _jumpHeight;

        public double JumpHeight {
            get { return _jumpHeight; }
            set { _jumpHeight = value; } }

        internal override void DoSound()
        {
            Console.WriteLine("Neigh neigh!");
        }
    }
}

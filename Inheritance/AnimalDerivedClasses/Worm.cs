using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Worm : Animal
    {
        private bool _isUnderground;

        public bool IsUnderGround {
            get { return _isUnderground; }
            set { _isUnderground = value; } }
        internal override void DoSound()
        {
            Console.WriteLine("Rrrrrrr");
        }
    }
}

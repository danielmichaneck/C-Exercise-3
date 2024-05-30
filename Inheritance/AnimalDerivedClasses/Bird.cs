using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        private bool _canFly;

        public bool CanFly {
            get { return _canFly; }
            set { _canFly = value; } }

        internal override void DoSound()
        {
            Console.WriteLine("Caw caw!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Wolf : Animal
    {
        private double _hearingRange;

        public double HearingRange {
            get { return _hearingRange; }
            set { _hearingRange = value; } }

        internal override void DoSound()
        {
            Console.WriteLine("Awoo! Awoo!");
        }
    }
}

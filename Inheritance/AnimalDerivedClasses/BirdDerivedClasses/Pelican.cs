using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Pelican : Bird
    {
        private double _mouthSize;

        public double MouthSize {
            get { return _mouthSize; }
            set { _mouthSize = value; } }

        public Pelican() : base(name: "Pelican", weight: 15, age: 20, canFly: true) { }
    }
}

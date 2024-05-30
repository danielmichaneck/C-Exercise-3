using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Swan : Bird
    {
        private double _wingSpan;

        public double WingSpan {
            get { return _wingSpan; }
            set { _wingSpan = value; } }

        public Swan() : base(name: "Swan", weight: 5, age: 5, canFly: true) { }
    }
}

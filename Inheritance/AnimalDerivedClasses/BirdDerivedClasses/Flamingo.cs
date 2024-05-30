using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Flamingo : Bird
    {
        private double _legLength;

        public double LegLength {
            get { return _legLength; }
            set { _legLength = value; } }

        public Flamingo() : base(name: "Flamingo", weight: 5, age: 10, canFly: true)
        {
            LegLength = 100;
            SetDerivedClassProperties();
        }

        internal override void SetDerivedClassProperties()
        {
            BirdProperties.Append($"LegLength: {LegLength}" + Environment.NewLine);
        }
    }
}

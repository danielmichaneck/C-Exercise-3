using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Wolf : Animal
    {
        private StringBuilder _wolfProperties;

        public StringBuilder WolfProperties
        {
            get { return _wolfProperties; }
            set { _wolfProperties = value; }
        }

        private double _hearingRange;

        public double HearingRange {
            get { return _hearingRange; }
            set { _hearingRange = value; } }

        public Wolf(string name = "Wolf")
        {
            Name = name;
            Weight = 100;
            Age = 7;
            HearingRange = 200;
            WolfProperties = StaticAnimalHelper.SetStandardAnimalProperties(Name, Weight, Age);
            StaticAnimalHelper.AppendAnimalProperty(WolfProperties, "Hearing range in meters", HearingRange.ToString());
        }

        public override string Stats()
        {
            return WolfProperties.ToString();
        }

        internal override void DoSound()
        {
            Console.WriteLine("Awoo! Awoo!");
        }
    }
}

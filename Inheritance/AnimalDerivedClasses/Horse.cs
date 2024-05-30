using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Horse : Animal
    {
        private StringBuilder _horseProperties;

        public StringBuilder HorseProperties
        {
            get { return _horseProperties; }
            set { _horseProperties = value; }
        }

        private double _jumpHeight;

        public double JumpHeight {
            get { return _jumpHeight; }
            set { _jumpHeight = value; } }

        public Horse()
        {
            Name = "Horse";
            Weight = 150;
            Age = 10;
            JumpHeight = 200;
            HorseProperties = StaticAnimalHelper.SetStandardAnimalProperties(Name, Weight, Age);
            StaticAnimalHelper.AppendAnimalProperty(HorseProperties, "Jump height in cm", JumpHeight.ToString());
        }

        public override string Stats()
        {
            return HorseProperties.ToString();
        }

        internal override void DoSound()
        {
            Console.WriteLine("Neigh neigh!");
        }
    }
}

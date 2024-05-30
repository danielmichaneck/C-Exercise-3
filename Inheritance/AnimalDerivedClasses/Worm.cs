using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Worm : Animal
    {
        private StringBuilder _wormProperties;

        public StringBuilder WormProperties
        {
            get { return _wormProperties; }
            set { _wormProperties = value; }
        }

        private bool _isUnderground;

        public bool IsUnderGround {
            get { return _isUnderground; }
            set { _isUnderground = value; } }

        public Worm()
        {
            Name = "Worm";
            Weight = 1;
            Age = 1;
            IsUnderGround = true;
            WormProperties = StaticAnimalHelper.SetStandardAnimalProperties(Name, Weight, Age);
            StaticAnimalHelper.AppendAnimalProperty(WormProperties, "Is underground", IsUnderGround.ToString());
        }

        public override string Stats()
        {
            return WormProperties.ToString();
        }

        internal override void DoSound()
        {
            Console.WriteLine("Rrrrrrr");
        }
    }
}

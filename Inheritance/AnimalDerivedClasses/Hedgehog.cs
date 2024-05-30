using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Hedgehog : Animal
    {
        private StringBuilder _hedgehogProperties;

        public StringBuilder HedgehogProperties
        {
            get { return _hedgehogProperties; }
            set { _hedgehogProperties = value; }
        }

        private int _numberOfSpikes;

        public int NumberOfSpikes {
            get { return _numberOfSpikes; }
            set { _numberOfSpikes = value; } }

        public Hedgehog()
        {
            Name = "Hedgehog";
            Weight = 1;
            Age = 1;
            NumberOfSpikes = 1000;
            HedgehogProperties = StaticAnimalHelper.SetStandardAnimalProperties(Name, Weight, Age);
            StaticAnimalHelper.AppendAnimalProperty(HedgehogProperties, "Number of spikes", NumberOfSpikes.ToString());
        }

        public override string Stats()
        {
            return HedgehogProperties.ToString();
        }

        internal override void DoSound()
        {
            Console.WriteLine("Ninini ninini!");
        }
    }
}

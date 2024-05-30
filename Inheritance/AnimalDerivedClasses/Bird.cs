using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        private bool _canFly = true;

        public bool CanFly {
            get { return _canFly; }
            set { _canFly = value; } }

        private StringBuilder _birdProperties;

        public StringBuilder BirdProperties {
            get { return _birdProperties; }
            set { _birdProperties = value; } }

        public Bird()
        {
            Name = "Bird";
            Weight = 0;
            Age = 0;
            CanFly = true;
            SetProperties();
        }

        public Bird(string name, double weight, int age, bool canFly)
        {
            Name = name;
            Weight = weight;
            Age = age;
            CanFly = canFly;
            SetProperties();
        }

        public override string Stats()
        {
            return BirdProperties.ToString();
        }

        internal void SetProperties()
        {
            BirdProperties = StaticAnimalHelper.SetStandardAnimalProperties(Name, Weight, Age);
            StaticAnimalHelper.AppendAnimalProperty(BirdProperties, "Can fly", CanFly.ToString());
        }

        internal virtual void SetDerivedClassProperties() {}

        internal override void DoSound()
        {
            Console.WriteLine("Caw caw!");
        }
    }
}

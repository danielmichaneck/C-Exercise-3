using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Dog : Animal
    {
        protected const bool IsGoodBoy = true;

        private StringBuilder _dogProperties;

        public StringBuilder DogProperties { 
            get { return _dogProperties; }
            set { _dogProperties = value; } }

        private double _speed;

        public double Speed {
            get { return _speed; }
            set { _speed = value; } }

        public Dog()
        {
            Name = "Dog";
            Weight = 20;
            Age = 5;
            Speed = 100;
            DogProperties = StaticAnimalHelper.SetStandardAnimalProperties(Name, Weight, Age);
            StaticAnimalHelper.AppendAnimalProperty(DogProperties, "Speed", Speed.ToString());
            StaticAnimalHelper.AppendAnimalProperty(DogProperties, "Is a good boy", IsGoodBoy.ToString());
        }

        /// <summary>
        /// F15
        /// New function unique to Dog.
        /// </summary>
        /// <param name="addedSpeed"></param>
        internal void AddSpeed(int addedSpeed)
        {
            Speed += addedSpeed;
            Console.WriteLine($"{Name} is now running at a speed of {Speed}!");
        }

        public override string Stats()
        {
            return DogProperties.ToString();
        }

        internal override void DoSound()
        {
            Console.WriteLine("Woof woof!");
        }
    }
}

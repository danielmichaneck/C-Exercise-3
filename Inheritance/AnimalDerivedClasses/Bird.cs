using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// A base class for Animals thar are Birds.
    /// </summary>
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

        /// <summary>
        /// Overloaded constructor allowing dervied
        /// classes to set their own properties.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weight"></param>
        /// <param name="age"></param>
        /// <param name="canFly"></param>
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

        /// <summary>
        /// Sets the properties of the bird, including the
        /// standard properties for all Animals and the
        /// unique property for birds.
        /// </summary>
        internal void SetProperties()
        {
            BirdProperties = StaticAnimalHelper.SetStandardAnimalProperties(Name, Weight, Age);
            StaticAnimalHelper.AppendAnimalProperty(BirdProperties, "Can fly", CanFly.ToString());
        }

        /// <summary>
        /// A virtual method that allows derived classes
        /// to set their own unique properties.
        /// </summary>
        internal virtual void SetDerivedClassProperties() {}

        internal override void DoSound()
        {
            Console.WriteLine("Caw caw!");
        }
    }
}

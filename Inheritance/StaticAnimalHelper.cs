using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// A static helped class for the project.
    /// </summary>
    internal static class StaticAnimalHelper
    {
        /// <summary>
        /// Returns an Animal depending on an int argument.
        /// Optionally runs a Random check to get a specific
        /// derived Animal class.
        /// </summary>
        /// <param name="animalInt"></param>
        /// <param name="random"></param>
        /// <returns></returns>
        internal static Animal GetAnimal(int animalInt, Random random)
        {
            switch (animalInt)
            {
                case 0:
                    if (random.Next(2) == 0)
                        return new Flamingo();
                    else if (random.Next(1) == 0)
                        return new Pelican();
                    else return new Swan();

                case 1:
                    return new Dog();

                case 2:
                    return new Hedgehog();

                case 3:
                    return new Horse();

                case 4:
                    return new Wolf();

                case 5:
                    return new Worm();

                default:
                    return new Wolfman();
            }
        }

        /// <summary>
        /// Returns standard Animal properties that all Animal and
        /// derived classes have as a string with new lines for
        /// each property using the arguments.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weight"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        internal static string GetStandardAnimalProperties(string name, double weight, int age)
        {
            return new string($"Name: {name}" + Environment.NewLine + 
                $"Weight: {weight}" + Environment.NewLine +
                $"Age: {age}" + Environment.NewLine);
        }

        /// <summary>
        /// Returns a StringBuilder with the standard animal
        /// properties.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weight"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        internal static StringBuilder SetStandardAnimalProperties(string name, double weight, int age)
        {
            return new StringBuilder(GetStandardAnimalProperties(name, weight, age));
        }

        /// <summary>
        /// Adds a property and its name to a StringBuilder
        /// in the correct format.
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        internal static void AppendAnimalProperty(StringBuilder properties, string propertyName, string value)
        {
            properties.Append($"{propertyName}: {value}" + Environment.NewLine);
        }
    }
}

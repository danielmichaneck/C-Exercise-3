using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal static class StaticAnimalHelper
    {
        internal static string GetStandardAnimalProperties(string name, double weight, int age)
        {
            return new string($"Name: {name}" + Environment.NewLine + 
                $"Weight: {weight}" + Environment.NewLine +
                $"Age: {age}" + Environment.NewLine);
        }

        internal static StringBuilder SetStandardAnimalProperties(string name, double weight, int age)
        {
            return new StringBuilder(GetStandardAnimalProperties(name, weight, age));
        }

        internal static void AppendAnimalProperty(StringBuilder properties, string propertyName, string value)
        {
            properties.Append($"{propertyName}: {value}" + Environment.NewLine);
        }
    }
}

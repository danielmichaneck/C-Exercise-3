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

    }
}

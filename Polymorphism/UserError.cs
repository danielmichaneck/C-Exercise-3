using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    /// <summary>
    /// An abstract class that all UserError messages
    /// inherits from.
    /// </summary>
    internal abstract class UserError
    {
        public abstract string UEMessage();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class OutOfBoundsInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a value that was too large for this field. This fired an error!";
        }
    }
}

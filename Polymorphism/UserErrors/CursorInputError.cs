using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class CursorInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a cursor on a touch screen. This fired an error!";
        }
    }
}

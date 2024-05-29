using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class CatInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a cat in a dog only field. This fired an error!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Wolfman : Wolf, IPerson
    {
        void IPerson.Talk()
        {
            Console.WriteLine("Awoo! Ahem, sorry. It's a full moon tonight.");
        }
    }
}

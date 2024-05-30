using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Hedgehog : Animal
    {
        private int _numberOfSpikes;

        public int NumberOfSpikes {
            get { return _numberOfSpikes; }
            set { _numberOfSpikes = value; } }

        public override string Stats()
        {
            throw new NotImplementedException();
        }

        internal override void DoSound()
        {
            Console.WriteLine("Ninini ninini!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tund02._10
{
    class Bird: Animal
    {
        public override void Talk()
        {
            Console.Write("Birds sing");
        }

        public override int legN { get { return 2; } }
    }
}

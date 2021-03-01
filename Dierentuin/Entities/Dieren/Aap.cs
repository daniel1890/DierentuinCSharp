using Dierentuin.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin
{
    class Aap : DierBase, IDier
    {
        public void Eet()
        {
            Console.WriteLine("De aap genaamd " + this.Naam + " eet.");
        }

        public void PlantVoor()
        {
            Console.WriteLine("De aap genaamd " + this.Naam + " maakt baby aapjes.");
        }
    }
}

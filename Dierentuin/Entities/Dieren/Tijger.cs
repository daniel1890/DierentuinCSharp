using Dierentuin.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin
{
    class Tijger : DierBase, IDier
    {
        public void Eet()
        {
            Console.WriteLine("De tijger genaamd " + this.Naam + " eet.");
        }

        public void PlantVoor()
        {
            Console.WriteLine("De tijger genaamd " + this.Naam + " maakt baby welpjes.");
        }
    }
}

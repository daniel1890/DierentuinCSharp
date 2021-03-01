using Dierentuin.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin
{
    class Vis : DierBase, IDier
    {
        public void Eet()
        {
            Console.WriteLine("De vis genaamd " + this.Naam + " eet.");
        }

        public void PlantVoor()
        {
            Console.WriteLine("De vis genaamd " + this.Naam + " maakt baby visjes");
        }
    }
}

using Dierentuin.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin
{
    internal class Vogel : Dier, IDier
    {
        public void Eet()
        {
            Console.WriteLine("De vogel genaamd " + this.Naam + " eet.");
        }

        public void PlantVoor()
        {
            Console.WriteLine("De vogel genaamd " + this.Naam + " maakt baby vogeltjes.");
        }
    }
}
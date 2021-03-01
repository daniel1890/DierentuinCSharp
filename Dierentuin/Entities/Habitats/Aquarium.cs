using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin
{
    class Aquarium
    {
        public List<Vis> Vissen = new List<Vis>();

        public void VoegVisToe(Vis vis)
        {
            Vissen.Add(vis);
        }

        public void PrintVissenEigenschappen()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Vissen in het aquarium: ");
            foreach (Vis vis in Vissen)
            {
                Console.WriteLine(vis.toString());
            }
        }
    }
}

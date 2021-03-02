using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin.Entities.HabitatBase
{
    public abstract class Habitat
    {
        public List<Dier> DierenLijst = new List<Dier>();

        public void VoegDierToe(Dier dier)
        {
            DierenLijst.Add(dier);
        }

        public void PrintDierenEigenschappen()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Dieren in de Jungle: ");
            foreach (Dier d in DierenLijst)
            {
                Console.WriteLine("Diernummer: " + (DierenLijst.IndexOf(d) + 1));
                Console.WriteLine(d.toString());
            }
        }
    }
}
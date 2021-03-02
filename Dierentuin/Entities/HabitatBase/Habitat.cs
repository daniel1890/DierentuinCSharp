using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin.Entities.HabitatBase
{
    public abstract class Habitat
    {
        public List<DierBase> DierenLijst = new List<DierBase>();

        public void VoegDierToe(DierBase dier)
        {
            DierenLijst.Add(dier);
        }

        public void PrintDierenEigenschappen()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Dieren in de Jungle: ");
            foreach (DierBase d in DierenLijst)
                Console.WriteLine(d.toString());
        }
    }
}
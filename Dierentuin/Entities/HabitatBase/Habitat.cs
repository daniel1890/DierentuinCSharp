using Dierentuin.Enums;
using Dierentuin.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin.Entities.HabitatBase
{
    public abstract class Habitat : IDierenFactory
    {
        public List<Dier> DierenLijst = new List<Dier>();

        public abstract Dier MaakDier(DierType type, string naam, int aantalLedematen);

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
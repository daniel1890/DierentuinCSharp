using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin
{
    class Jungle
    {
        public List<Tijger> Tijgers = new List<Tijger>();
        public List<Aap> Apen = new List<Aap>();

        public void VoegTijgerToe(Tijger tijger)
        {
            Tijgers.Add(tijger);
        }

        public void VoegAapToe(Aap aap)
        {
            Apen.Add(aap);
        }

        public void PrintTijgersEigenschappen()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Tijgers in de Jungle: ");
            foreach (Tijger tijger in Tijgers)
            {
                Console.WriteLine(tijger.toString());
            }
        }

        public void PrintApenEigenschappen()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Apen in de Jungle: ");
            foreach (Aap aap in Apen)
            {
                Console.WriteLine(aap.toString());
            }
        }
    }
}

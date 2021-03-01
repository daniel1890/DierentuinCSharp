using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin
{
    class Vogelhok
    {
        public List<Vogel> Vogels = new List<Vogel>();

        public void VoegVogelToe(Vogel vogel)
        {
            Vogels.Add(vogel);
        }

        public void PrintvogelsEigenschappen()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Vogels in het vogelhok: ");
            foreach (Vogel vogel in Vogels)
            {
                Console.WriteLine(vogel.toString());
            }
        }
    }
}

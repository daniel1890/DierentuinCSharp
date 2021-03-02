using Dierentuin.Entities.HabitatBase;
using Dierentuin.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin.Entities.Habitats
{
    internal sealed class Apenkooi : Habitat
    {
        public override Dier MaakDier(DierType type, string naam, int aantalLedematen)
        {
            Aap aap = new Aap() { Naam = naam, AantalLedematen = aantalLedematen };
            return aap;
        }
    }
}
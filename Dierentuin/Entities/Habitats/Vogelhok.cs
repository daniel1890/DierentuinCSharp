using Dierentuin.Entities.HabitatBase;
using Dierentuin.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin
{
    internal sealed class Vogelhok : Habitat
    {
        public override Dier MaakDier(DierType type, string naam, int aantalLedematen)
        {
            Vogel vogel = new Vogel() { Naam = naam, AantalLedematen = aantalLedematen };
            return vogel;
        }
    }
}
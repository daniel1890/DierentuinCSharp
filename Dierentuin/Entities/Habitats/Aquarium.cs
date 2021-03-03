using Dierentuin.Entities.HabitatBase;
using Dierentuin.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin
{
    internal sealed class Aquarium : Habitat
    {
        public override Dier MaakDier(DierType type, string naam, int aantalLedematen)
        {
            Vis vis = new Vis() { Naam = naam, AantalLedematen = aantalLedematen };
            return vis;
        }
    }
}
﻿using Dierentuin.Entities.HabitatBase;
using Dierentuin.Enums;
using System;
using System.Text;

namespace Dierentuin
{
    internal sealed class Jungle : Habitat
    {
        public override Dier MaakDier(DierType type, string naam, int aantalLedematen)
        {
            Tijger tijger = new Tijger() { Naam = naam, AantalLedematen = aantalLedematen };
            return tijger;
        }
    }
}
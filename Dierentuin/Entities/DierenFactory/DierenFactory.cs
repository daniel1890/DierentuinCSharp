using Dierentuin.Enums;
using Dierentuin.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin.Entities.DierenFactory
{
    public class DierenFactory : IDierenFactory
    {
        public Dier MaakDier(DierType type, string naam, int aantalLedematen)
        {
            switch (type)
            {
                case DierType.Tijger:
                    return new Tijger() { Naam = naam, AantalLedematen = aantalLedematen };

                case DierType.Vis:
                    return new Vis() { Naam = naam, AantalLedematen = aantalLedematen };

                case DierType.Aap:
                    return new Aap() { Naam = naam, AantalLedematen = aantalLedematen };

                case DierType.Vogel:
                    return new Vogel() { Naam = naam, AantalLedematen = aantalLedematen };

                default:
                    return new Tijger() { Naam = naam, AantalLedematen = aantalLedematen };
            }
        }
    }
}

/*
public IFan CreateFan(FanType type)
{
    switch (type)
    {
        case FanType.TableFan:
            return new TableFan();

        case FanType.CeilingFan:
            return new CeilingFan();

        case FanType.ExhaustFan:
            return new ExhaustFan();

        default:
            return new TableFan();
    }
}

*/
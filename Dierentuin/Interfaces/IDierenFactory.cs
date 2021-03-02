using Dierentuin.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin.Interfaces
{
    internal interface IDierenFactory
    {
        public Dier MaakDier(DierType type, string naam, int aantalLedematen);
    }
}
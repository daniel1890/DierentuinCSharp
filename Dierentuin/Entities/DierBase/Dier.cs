using Dierentuin.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin
{
    abstract class DierBase
    {
        public string Naam { get; set; }
        public int AantalLedematen { get; set; }
        public Guid guid;

        public DierBase() {
            guid = Guid.NewGuid();
        }

        public string toString()
        {
            return "\nNummer van het dier: " + guid + ".\nNaam van het dier: " + Naam + "\nHet dier heeft " + AantalLedematen + " aantal ledematen.";
        }
    }
}

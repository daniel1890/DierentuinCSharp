using Dierentuin.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin
{
    public abstract class DierBase
    {
        public string Naam { get; set; }
        public int AantalLedematen { get; set; }
        public Guid guid;

        public DierBase()
        {
            guid = Guid.NewGuid();
        }

        public string toString()
        {
            string diertype = GetType().ToString();
            string dierentuin = "Dierentuin.";
            return "Diersoort: " + diertype.Remove(0, dierentuin.Length) + ".\nNummer van het dier: " + guid + ".\nNaam van het dier: " + Naam + "\nHet dier heeft " + AantalLedematen + " aantal ledematen.\n";
        }
    }
}
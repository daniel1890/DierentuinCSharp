using Dierentuin.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin
{
    public abstract class Dier
    {
        public string Naam { get; set; }
        public int AantalLedematen { get; set; }
        public Guid guid;

        public Dier()
        {
            guid = Guid.NewGuid();
        }

        public string toString()
        {
            return "Diersoort: " + _getThisClassName() + ".\nUniek GUID van het dier: " + guid + ".\nNaam van het dier: " + Naam + ".\nHet dier heeft " + AantalLedematen + " aantal ledematen.\n";
        }

        private string _getThisClassName()
        {
            return this.GetType().Name;
        }
    }
}
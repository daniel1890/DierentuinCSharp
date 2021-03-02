using Dierentuin.Entities.DierenFactory;
using Dierentuin.Entities.HabitatBase;
using Dierentuin.Enums;
using System;

namespace Dierentuin
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Dierentuin Dierentuin = new Dierentuin();

            // Maak een dierenfactory om dieren mee te creeëren.
            DierenFactory dierenFactory = new DierenFactory();

            // Voeg een vogel object toe aan de dierentuin.
            Vogel vogel = new Vogel { Naam = "Henk", AantalLedematen = 2 };
            Dierentuin.Vogelhok.VoegDierToe(vogel);

            // Voeg een tijger object toe aan de dierentuin
            var tijger = new Tijger { Naam = "Gert", AantalLedematen = 4 };
            Dierentuin.Jungle.VoegDierToe(tijger);

            // Voeg een vis object toe aan de dierentuin
            var vis = new Vis { Naam = "Klaas", AantalLedematen = 2 };
            Dierentuin.Aquarium.VoegDierToe(vis);

            // Voeg een aap object toe aan de dierentuin
            var aap1 = new Aap { Naam = "Piet", AantalLedematen = 4 };
            var aap2 = new Aap { Naam = "Dirk", AantalLedematen = 4 };
            var aap3 = dierenFactory.MaakDier(DierType.Aap, "Bokito", 4);
            Dierentuin.Apenkooi.VoegDierToe(aap1);
            Dierentuin.Apenkooi.VoegDierToe(aap2);
            Dierentuin.Apenkooi.VoegDierToe(aap3);

            // Print de eigenschappen van de dieren binnen elke habitat en laat elk eten en voortplanten.
            Dierentuin.Jungle.PrintDierenEigenschappen();
            tijger.Eet();
            tijger.PlantVoor();

            Dierentuin.Aquarium.PrintDierenEigenschappen();
            vis.PlantVoor();
            vis.Eet();

            Dierentuin.Vogelhok.PrintDierenEigenschappen();
            vogel.PlantVoor();
            vogel.Eet();

            Dierentuin.Apenkooi.PrintDierenEigenschappen();
            aap1.PlantVoor();
            aap1.Eet();
            aap2.PlantVoor();
            aap2.Eet();
        }
    }
}
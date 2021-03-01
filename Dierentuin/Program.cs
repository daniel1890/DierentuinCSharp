using System;

namespace Dierentuin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Dierentuin Dierentuin = new Dierentuin();

            // Voeg een vogel object toe aan de dierentuin.
            Vogel vogel = new Vogel
            {
                Naam = "Henk",
                AantalLedematen = 2
            };
            Dierentuin.Vogelhok.VoegVogelToe(vogel);

            // Voeg een tijger object toe aan de dierentuin
            var tijger = new Tijger
            {
                Naam = "Gert",
                AantalLedematen = 4
            };
            Dierentuin.Jungle.VoegTijgerToe(tijger);

            // Voeg een vis object toe aan de dierentuin
            var vis = new Vis
            {
                Naam = "Klaas",
                AantalLedematen = 2
            };
            Dierentuin.Aquarium.VoegVisToe(vis);

            // Voeg een aap object toe aan de dierentuin
            var aap1 = new Aap
            {
                Naam = "Piet",
                AantalLedematen = 4
            };
            Dierentuin.Jungle.VoegAapToe(aap1);

            var aap2 = new Aap
            {
                Naam = "Dirk",
                AantalLedematen = 4
            };
            Dierentuin.Jungle.VoegAapToe(aap2);

            Dierentuin.Jungle.PrintTijgersEigenschappen();
            tijger.PlantVoor();

            Dierentuin.Aquarium.PrintVissenEigenschappen();
            vis.PlantVoor();

            Dierentuin.Vogelhok.PrintvogelsEigenschappen();
            vogel.PlantVoor();

            Dierentuin.Jungle.PrintApenEigenschappen();
            aap1.PlantVoor();
            aap2.PlantVoor();
        }
    }
}
using System;

namespace Les1Oefeninging2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dit programma zal het nodige aantal kg zaad berekenen.\n");
            Console.WriteLine("Geef de volgende gegevens in:");
            Console.Write("Lengte veld: ");
            double lengte = double.Parse(Console.ReadLine());
            Console.Write("Breedte veld: ");
            double breedte = double.Parse(Console.ReadLine());
            Console.Write("Aantal kg zaad per m2: ");
            double zaad = double.Parse(Console.ReadLine());

            double opp = lengte * breedte;
            double aantalZaad = opp * zaad;

            Console.WriteLine("\nDe oppervlakte van het veld is: " + opp);
            Console.WriteLine("Het aantal kg zaad nodig is: " + aantalZaad);
        }
    }
}

using System;

namespace Les2Oefeningen2
{
    class Program
    {
        static void Main(string[] args)
        {
            double straal;
            double hoogte;
            double oppervlakte;
            double inhoud;

            Console.WriteLine("Gelieve de volgende gegevens van de cilinder in te geven:");
            Console.Write( "- Straal (cm): ");
            straal = double.Parse(Console.ReadLine());
            Console.Write("- Hoogte (cm): ");
            hoogte = double.Parse(Console.ReadLine());

            oppervlakte = Math.Round(((2 * Math.PI * straal) * hoogte),2);
            Console.WriteLine("\nDe oppervlakte van de cilinder is: " + oppervlakte + " cm²");

            inhoud = Math.Round((Math.PI * Math.Pow(straal, 2) * hoogte),2);
            Console.WriteLine("De inhoud van de cilinder is: " + inhoud + " cm³");

        }
    }
}

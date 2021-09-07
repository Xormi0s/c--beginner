using System;

namespace Les1Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gelieve een design karakter te kiezen (vb *, #, // ...)");
            string karakter = Console.ReadLine();
            Console.WriteLine("Gelieve je coordinaten in te geven:");
            Console.Write("Voornaam: ");
            string voornaam = Console.ReadLine();
            Console.Write("Familienaam: ");
            string familienaam = Console.ReadLine();
            Console.Write("Adres: ");
            string adres = Console.ReadLine();
            Console.Write("Postcode: ");
            string postcode = Console.ReadLine();
            Console.Write("Plaats: ");
            string plaats = Console.ReadLine();

            Console.WriteLine("\n" + karakter + karakter + karakter);
            Console.WriteLine(karakter + "\tVoornaam\t: " + voornaam);
            Console.WriteLine(karakter + "\tFamilienaam\t: " + familienaam);
            Console.WriteLine(karakter + "\tAdres\t\t: " + adres);
            Console.WriteLine(karakter + "\tPostcode\t: " + postcode);
            Console.WriteLine(karakter + "\tPlaats\t\t: " + plaats);
            Console.WriteLine(karakter + karakter + karakter);
        }
    }
}

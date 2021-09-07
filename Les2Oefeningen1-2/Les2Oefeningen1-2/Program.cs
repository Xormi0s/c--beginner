using System;

namespace Les2Oefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1;
            int getal2;
            int getal3;
            int somGetallen;

            Console.WriteLine("Gelieve 3 gehele getallen in te geven");
            Console.Write("Getal 1: ");
            getal1 = int.Parse(Console.ReadLine());
            Console.Write("Getal 2: ");
            getal2 = int.Parse(Console.ReadLine());
            Console.Write("Getal 3: ");
            getal3 = int.Parse(Console.ReadLine());

            somGetallen = getal1 + getal2 + getal3;
            Console.Write("De som van de 3 getallen is: " + somGetallen);

        }
    }
}

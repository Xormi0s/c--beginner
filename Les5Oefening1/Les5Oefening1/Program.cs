using System;

namespace Les5Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Boolean repeatinput = true;
            SimBox simbox1 = new SimBox();
            string telefoonnummer;
            int tempkeuze = 0;


            while (repeatinput)
            {
                Console.WriteLine("*** SIMBOX ***");
                Console.WriteLine("1. Simkaart gegevens ingeven");
                Console.WriteLine("2. Overzicht SIM kaart gegevens");
                Console.WriteLine("3. Bellen");
                Console.WriteLine("4. Stop");

                Console.Write("> ");
                if(!int.TryParse(Console.ReadLine(), out input)){
                    input = 5;
                }

                switch (input)
                {
                    case 1:
                        if (simbox1.Simkaart1 == null)
                        {
                            Console.Write("Geef het telefoonnummer van SIM kaart 1 in: ");
                            telefoonnummer = Console.ReadLine();
                            SimKaart tempsim = new SimKaart(telefoonnummer);
                            simbox1.Simkaart1 = tempsim;
                            input = 0;
                            Console.WriteLine("Druk op een toets om verder te gaan");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (simbox1.Simkaart1 != null & simbox1.Simkaart2 == null)
                        {
                            Console.Write("Geef het telefoonnummer van SIM kaart 2 in: ");
                            telefoonnummer = Console.ReadLine();
                            SimKaart tempsim = new SimKaart(telefoonnummer);
                            simbox1.Simkaart2 = tempsim;
                            input = 0;
                            Console.WriteLine("Druk op een toets om verder te gaan");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        if (simbox1.Simkaart2 != null & input != 0)
                        {
                            Console.WriteLine("Maximaal aantal SIM kaarten geïnstalleerd.");
                            input = 0;
                            Console.WriteLine("Druk op een toets om verder te gaan");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;

                    case 2:
                        Console.WriteLine("Overzicht geïnstalleerde SIM kaarten:");
                        if (simbox1.Simkaart1 != null)
                        {
                            Console.WriteLine("SIM kaart 1 -");
                            Console.WriteLine(simbox1.Simkaart1.GeefOmschrijving());
                        }
                        else
                        {
                            Console.WriteLine("Er zijn nog geen SIM kaarten toegevoegd.");
                        }
                        if (simbox1.Simkaart2 != null)
                        {
                            Console.WriteLine("SIM kaart 2 -");
                            Console.WriteLine(simbox1.Simkaart2.GeefOmschrijving());
                        }
                        input = 0;
                        Console.WriteLine("Druk op een toets om verder te gaan");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        if (simbox1.Simkaart1 != null)
                        {
                            Console.WriteLine("Selecteer de SIM kaart waarmee je wil bellen:");
                            Console.WriteLine("1. " + simbox1.Simkaart1.telefoonnummer);
                        }
                        else
                        {
                            Console.WriteLine("Er zijn nog geen SIM kaarten toegevoegd.");
                        }
                        if (simbox1.Simkaart2 != null)
                        {
                            Console.WriteLine("2. " + simbox1.Simkaart2.telefoonnummer);
                        }
                        if (simbox1.Simkaart1 != null)
                        {
                            Console.Write("> ");
                            tempkeuze = int.Parse(Console.ReadLine());
                        }
                        if (tempkeuze == 1)
                        {
                            Console.Write("Geef het telefoonnummer in: ");
                            simbox1.Simkaart1.Bel(Console.ReadLine());
                            Console.WriteLine("Nummer " + simbox1.Simkaart1.Laatstenummer + " werd opgebeld.");
                        }
                        if (tempkeuze == 2)
                        {
                            Console.Write("Geef het telefoonnummer in: ");
                            simbox1.Simkaart2.Bel(Console.ReadLine());
                            Console.WriteLine("Nummer " + simbox1.Simkaart2.Laatstenummer + " werd opgebeld.");
                        }
                        if (tempkeuze != 1 & tempkeuze != 2 & simbox1.Simkaart1 != null)
                        {
                            Console.WriteLine("Ongeldige keuze !");
                        }
                        input = 0;
                        Console.WriteLine("Druk op een toets om verder te gaan");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        Console.WriteLine("Programma word afgesloten !");
                        repeatinput = false;
                        break;

                    default:
                        Console.WriteLine("Ongeldige keuze. Programma word afgesloten.");
                        repeatinput = false;
                        break;
                }
            }
        }
    }
}

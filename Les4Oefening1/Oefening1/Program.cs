using System;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Boolean repeatinput = true;
            SimBox simbox1 = new SimBox();
            string telefoonnummer;

            Console.WriteLine("*** SIMBOX ***");
            Console.WriteLine("1. Simkaart gegevens ingeven");
            Console.WriteLine("2. Overzicht SIM kaart gegevens");
            Console.WriteLine("3. Aantal geïnstalleerde SIM kaarten.");
            Console.WriteLine("4. Stop");


            while (repeatinput)
            {
                Console.Write("> ");
                input = int.Parse(Console.ReadLine());

                switch (input){
                    case 1:
                        if (simbox1.Aantalkaarten == 0)
                        {
                            Console.Write("Geef het telefoonnummer van SIM kaart 1 in: ");
                            telefoonnummer = Console.ReadLine();
                            SimKaart tempsim = new SimKaart(telefoonnummer);
                            simbox1.Simkaart1 = tempsim;
                            input = 0;
                            Console.WriteLine("Druk op een toets om verder te gaan");
                            Console.ReadLine();
                        }
                        else if (simbox1.Aantalkaarten == 1)
                        {
                            Console.Write("Geef het telefoonnummer van SIM kaart 2 in: ");
                            telefoonnummer = Console.ReadLine();
                            SimKaart tempsim = new SimKaart(telefoonnummer);
                            simbox1.Simkaart2 = tempsim;
                            input = 0;
                            Console.WriteLine("Druk op een toets om verder te gaan");
                            Console.ReadLine();
                        }
                        else if (simbox1.Aantalkaarten == 2)
                        {
                            Console.Write("Geef het telefoonnummer van SIM kaart 3 in: ");
                            telefoonnummer = Console.ReadLine();
                            SimKaart tempsim = new SimKaart(telefoonnummer);
                            simbox1.Simkaart3 = tempsim;
                            input = 0;
                            Console.WriteLine("Druk op een toets om verder te gaan");
                            Console.ReadLine();
                        }
                        if(simbox1.Aantalkaarten == 3 && input != 0)
                        {
                            Console.WriteLine("Maximaal aantal SIM kaarten geïnstalleerd.");
                            input = 0;
                            Console.WriteLine("Druk op een toets om verder te gaan");
                            Console.ReadLine();
                        }
                        break;

                    case 2:
                        Console.WriteLine("Overzicht geïnstalleerde SIM kaarten:");
                        if (simbox1.Simkaart1 != null)
                        {
                            Console.WriteLine("SIM kaart 1: " + simbox1.Simkaart1.telefoonnummer + " / Facturatie datum: " + simbox1.Simkaart1.creatiedatum);
                        } else
                        {
                            Console.WriteLine("Er zijn nog geen SIM kaarten toegevoegd.");
                        }
                        if (simbox1.Simkaart2 != null)
                        {
                            Console.WriteLine("SIM kaart 2: " + simbox1.Simkaart2.telefoonnummer + " / Facturatie datum: " + simbox1.Simkaart2.creatiedatum);
                        }
                        if (simbox1.Simkaart3 != null)
                        {
                            Console.WriteLine("SIM kaart 3: " + simbox1.Simkaart3.telefoonnummer + " / Facturatie datum: " + simbox1.Simkaart3.creatiedatum);
                        }
                        input = 0;
                        Console.WriteLine("Druk op een toets om verder te gaan");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Aantal geïnstalleerde SIM kaarten: " + simbox1.Aantalkaarten + " (nog " + (3 - simbox1.Aantalkaarten) + " slot(s) vrij)");
                        Console.WriteLine("Druk op een toets om verder te gaan");
                        Console.ReadLine();
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

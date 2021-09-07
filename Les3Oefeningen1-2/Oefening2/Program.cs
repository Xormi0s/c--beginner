using System;

namespace Oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean repeat1 = true;
            Boolean repeat2;
            int getal = 1;
            int input;
            int max = 0;
            int gemiddelde = 0;
            int som = 0;
            string invoer;

            Console.WriteLine("Gelieve een reeks positieve getallen in te geven. Negatief om te stoppen.\n");

            while (repeat1)
            {
                Console.Write(getal + "> ");
                input = int.Parse(Console.ReadLine());

                if (input > max)
                {
                    max = input;
                }

                if (input < 0 && som <= 0)
                {
                    Console.WriteLine("Het gemiddelde en maximum kan niet bepaald worden, er werden geen getallen ingegeven.");
                    Console.Write("Opnieuw het gemiddelde en maxium bepalen ? <j/n>: ");
                    invoer = Console.ReadLine();
                    getal = 0;
                    repeat2 = true;

                    while (repeat2)
                    {
                        switch (invoer)
                        {
                            case "n":
                                repeat1 = false;
                                repeat2 = false;
                                break;
                            case "j":
                                repeat2 = false;
                                gemiddelde = 0;
                                som = 0;
                                max = 0;
                                break;
                            default:
                                Console.WriteLine("Gelieve j of n in te geven !");
                                Console.Write(" > ");
                                invoer = Console.ReadLine();
                                break;
                        }
                    }
                }
                else if (input < 0)
                {
                    gemiddelde = som / getal;
                    Console.WriteLine("Het maximum van de ingegeven reeks is: " + max);
                    Console.WriteLine("Het gemiddelde van de ingegeven reeks is: " + gemiddelde);
                    Console.Write("Opnieuw het gemiddelde en maxium bepalen ? <j/n>: ");
                    invoer = Console.ReadLine();
                    getal = 0;
                    repeat2 = true;

                    while (repeat2)
                    {
                        switch (invoer)
                        {
                            case "n":
                                repeat1 = false;
                                repeat2 = false;
                                break;
                            case "j":
                                repeat2 = false;
                                gemiddelde = 0;
                                som = 0;
                                max = 0;
                                break;
                            default:
                                Console.WriteLine("Gelieve j of n in te geven !");
                                Console.Write(" > ");
                                invoer = Console.ReadLine();
                                break;
                        }
                    }
                }
                else
                {
                    som = som + input;
                }
                getal++;
            }
        }
    }
}
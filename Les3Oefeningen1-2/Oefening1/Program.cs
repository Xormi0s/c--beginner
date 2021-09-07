using System;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempkeuze;
            double temphuidig;
            double tempC;
            double tempK;
            double tempF;

            string invoer = "Gelieve de huidige temperatuur in de gekozen schaal in te geven: ";
            string ongeldig = "Ongeldige temperatuur. Het programma word afgesloten.";
            string celsius = "Celsius\t\t\t:\t\t";
            string kelvin = "Kelvin\t\t\t:\t\t";
            string fahr = "Fahrenheit\t\t:\t\t";
            string output = "\nOverzicht in alle temperatuur schalen:";

            Console.WriteLine("Gelieve de temperatuurschaal te kiezen:");
            Console.WriteLine("1. Celcius");
            Console.WriteLine("2. Kelvin");
            Console.WriteLine("3. Fahrenheit");
            Console.Write(" > ");

            tempkeuze = int.Parse(Console.ReadLine());


            switch (tempkeuze)
            {
                case 1:
                    Console.Write(invoer);
                    temphuidig = double.Parse(Console.ReadLine());

                    if (temphuidig < -273.15)
                    {
                        Console.WriteLine(ongeldig);
                    }
                    else
                    {
                        tempC = temphuidig;
                        tempK = temphuidig + 273.15;
                        tempF = ((9.0 / 5.0) * temphuidig) + 32.0;

                        Console.WriteLine(output);
                        Console.WriteLine(celsius + tempC);
                        Console.WriteLine(fahr + tempF);
                        Console.WriteLine(kelvin + tempK);
                    }
                    break;

                case 2:
                    Console.Write(invoer);
                    temphuidig = double.Parse(Console.ReadLine());

                    if (temphuidig < 0)
                    {
                        Console.WriteLine(ongeldig);
                    }
                    else
                    {
                        tempK = temphuidig;
                        tempC = temphuidig - 273.15;
                        tempF = ((9.0 / 5.0) * tempC) + 32.0;

                        Console.WriteLine(output);
                        Console.WriteLine(celsius + tempC);
                        Console.WriteLine(fahr + tempF);
                        Console.WriteLine(kelvin + tempK);
                    }
                    break;

                case 3:
                    Console.Write(invoer);
                    temphuidig = double.Parse(Console.ReadLine());

                    if (temphuidig < -459.4)
                    {
                        Console.WriteLine(ongeldig);
                    }
                    else
                    {
                        tempF = temphuidig;
                        tempC = (5.0 / 9.0) * (temphuidig - 32.0);
                        tempK = tempC + 273.15;

                        Console.WriteLine(output);
                        Console.WriteLine(celsius + tempC);
                        Console.WriteLine(fahr + tempF);
                        Console.WriteLine(kelvin + tempK);
                    }
                    break;

                default:
                    Console.WriteLine("Ongeldige temperatuurschaal. Het programma zal afsluiten.");
                    break;
            }
        }
    }
}

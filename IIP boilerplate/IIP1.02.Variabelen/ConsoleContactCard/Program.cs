using System;
using System.Globalization;

public class ConsoleContactCard
{
static void Main (string[] args)
     {
		string naam = "Bobby Peru";
        bool gehuwd = false;
        string telefoon = "0486/33.22.19";
        int leeftijd = 25;
        decimal salaris = 2500.00m;
        char geslacht = 'm';
        double lengte = 1.75;

        string output = $@"
---------------
*
* Naam: {naam}
* Gehuwd: {(gehuwd ? "ja" : "nee")}
* Telefoon: {telefoon}
* Leeftijd: {leeftijd} jaar
* Salaris: {salaris.ToString("C", new CultureInfo("nl-BE"))} per maand
* Geslacht: {geslacht}
* Lengte : {lengte:F2}m
---------------
";
        Console.WriteLine(output);
        Console.WriteLine("druk op een toets om verder te gaan...");
        Console.ReadKey();		
     }
}
using System;
using System.Globalization;

public class ConsoleAbonnement
{
static void Main (string[] args)
     {
		Console.WriteLine("Bestelgegevens");
		Console.WriteLine("==============");
		
		Console.Write("-naam klant: ");
		string naam = Console.ReadLine();
		
		Console.Write("- aantal toegangsbeurten: ");
		int beurten = int.Parse(Console.ReadLine());
		
		Console.Write("- prijs (b.v. 122,5): ");
		decimal prijs = decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
		
		Console.Write("- badkledij inbegrepen (typ true of false): ");
		bool badkledij = bool.Parse(Console.ReadLine());
		
		Console.Write("- geslacht (druk 'm' of 'v'): ");
		char geslacht = Console.ReadKey().KeyChar;
		Console.WriteLine();
		
		Random rnd = new Random();
	    string kaartNummer = $"{rnd.Next(100, 1000)}-{rnd.Next(1000, 10000)}-{rnd.Next(10, 100)}";
		
		Console.ForegroundColor = ConsoleColor.Yellow;
		
	 
	 
		

Console.WriteLine($@"
Samenvatting
=============

- houder: {naam}
- geslacht: {geslacht}
- prijs: {prijs.ToString("C", new CultureInfo("nl-BE"))}
- aantal beurten: {beurten}
- incl. badkledij: {badkledij}
- kaartnummer: {kaartNummer}
");

        Console.ResetColor();
		
		Console.WriteLine("druk op een toets om verder te gaan...");
		Console.ReadKey();						 		
     }
}
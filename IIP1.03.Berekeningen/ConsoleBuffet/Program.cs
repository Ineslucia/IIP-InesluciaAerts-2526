using System;
using System.Globalization;

namespace ConsoleBuffet
{
  class Program
  {
    static void Main(string[]args)
	{
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine(@"
		WELKOM IN HET BUFFETRESTAURANT
		==============================
		
		
		Alles is à volonté en dranken zijn inbegrepen!
		!!Promotie!! Vandaag ronden we het totaalbedrag af naar beneden
		");
		Console.ResetColor();
		
		const double PrijsSeizoen = 18.5;
		const double PrijsDessert = 7.95;
		const double PrijsKids = 8.95;
		
		Console.Write($"Aantal seizoensbuffets (€{PrijsSeizoen}): ");
		int aantalSeizoensBuffets = int.Parse(Console.ReadLine());
		
		Console.Write($"Aantal dessertenbuffets (€{PrijsDessert}): ");
		int aantalDessertenBuffets = int.Parse(Console.ReadLine());
		
		Console.Write($"Aantal kids menu (€{PrijsKids}): ");
		int aantalKidsMenu = int.Parse(Console.ReadLine());
		
		Console.Write("Fooi (0 indien geen): ");
		double fooi = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
		
		double totaalBedrag = (aantalSeizoensBuffets * PrijsSeizoen)
		                    + (aantalDessertenBuffets * PrijsDessert)
							+ (aantalKidsMenu * PrijsKids)
							+ fooi;
		double afgerond = Math.Floor(totaalBedrag);
		
		Console.Write($"Totaal te betalen: €{totaalBedrag:F2}");
		Console.Write($"Afgerond naar beneden: €{afgerond}");
		
		Console.Write("\nCash betaald: ");
		double cash = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
		double terug = cash - afgerond;
		Console.WriteLine($"U krijgt terug: {terug}");
		
		
	int[] waarden = {50, 20, 10, 5, 2, 1};
	int wissel = (int)terug;
	
	foreach (int waarde in waarden)
	{
		int aantal = wissel / waarde;
		wissel %= waarde;
		string label = waarde >= 5? "briefje(s)" : "stuk(ken)";
		Console.WriteLine($"{aantal} {label} van {waarde}");
		
	  }
	}
  }
}
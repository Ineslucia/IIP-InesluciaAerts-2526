using System;
using System.Globalization;
using System.Text;

namespace ConsoleBri
{
  class Program
  {
    static void Main(string[]args)
	{
		Console.OutputEncoding = Encoding.UTF8;
		Console.WriteLine(@"
BRI CALCULATOR 🏋️
=================
");
		
		const double basis = 364.2;
        const double factor = 365.5;	

		const double BovenGrens = 4.44;
		const double OnderGrens = 3.41;
		
		Console.Write("Taille (in cm): ");
		int tailleInCm = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Lengte (in cm): ");
		int lengteInCm = Convert.ToInt32(Console.ReadLine());
		
		double verhouding = tailleInCm / (lengteInCm * 1.0);
		double bri = 364.2 - 365.5 * Math.Sqrt(1 - Math.Pow((tailleInCm / (2 * Math.PI)) /lengteInCm, 2));
		
		bri = Math.Round(bri,1);
		
		Console.ForegroundColor = ConsoleColor.Green;
		Console.Write($"Je BRI bedraagt: {bri:F1}\n");
		
		Console.ResetColor();
		
		Console.WriteLine($"Een BRI tussen {OnderGrens:F2} en {BovenGrens:F2} is normaal.");
		
	}
  }
}
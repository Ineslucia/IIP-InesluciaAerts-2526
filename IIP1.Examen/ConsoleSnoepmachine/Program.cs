using System;
using System.Globalization;


class Program
{
 static void Main()
 {
    Console.OutputEncoding System.Text.Encoding.UTF8;
 
    const decimal PrijsDrank = 2. 00m;
    const decimal PrijsSnoep = 1. 50m;
 
    CultureInfo nl = CultureInfo.GetCultureInfo("nl-NL");
 
 
    Console.WriteLine("SNOEPMACHINE 🍭🥤");
	Console.WriteLine("a. geld inwerpen");
	Console.WriteLine("b. drank kopen (2. 00 euro) ");
	Console.WriteLine("c. snoep kopen (1. 50 euro) ");
	Console.WriteLine("d. stoppen");
	
	decimal huidigeSaldo = 0.0m;
	Console.Write($"Huidige saldo: {saldo.ToString("C", nl)}");
	decimal huidigeSaldo = Console.ReadLine();
	Console.Write("Maak je keuze: ");
	string keuze = Console.ReadLine();
	Console.WriteLine();
	
	
	switch (keuze)
	{
	case "a": 
	       decimal huidigeSaldo;
        
	       Console.Write($"Inworp: {inworp}");
		   if (!decimal.TryParse(Console.ReadLine(), out decimal huidigeSaldo))
		   {
		      if (inworp % 0.5 != 0)
			  
			  Console.WriteLine("Alleen muntstukken van 0.5 euro of veelvouden daarvan zijn toegelaten");
			}
			else
			{  
		      for (i = 0; i < inworp; i += 0.5m);
		       { 
		      Console.Write("🪙");
		       }
		    }
    
	case "b": 
	      decimal nieuweSaldo = huidigeSaldo;
	      nieuweSaldo = huidigeSaldo - PrijsDrank;
	      Console.WriteLine("Je drankje komt eraan!");
		  break;
	
	case "c": nieuweSaldo = huidigeSaldo - PrijsSnoep;
	Console.WriteLine("Je snoepje komt eraan!");
	break;
	
	case "d": Console.WriteLine("Je krijgt {huidigeSaldo} euro terug.");
	default: Console.WriteLine($"'{keuze}' is geen geldige keuze, druk op een toets om verder te gaan...");
	break;
		
		}
	}	
}
	
	
	
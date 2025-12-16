using System;

class Program
{
  //Methodes
static bool NaamBestaat(string[] arr, string naam)
{
  foreach (string n in arr)
  {
   if (n == naam)
   return true;
  }
   return false;
}

static int? ZoekVolgnummer(string[] arr, string naam)
{
  for (int i =0; i < arr.Length; i++)
  {
  if (arr[i] == naam)
  return i + 1;
  }
  return null;
}

static string ZoekOpWoord(string[] arr, string woord)
{
  foreach (string n in arr)
  {
  if (n.Contains(woord))
  return n;
  }
  return null;
}

static string ZoekOpLengte(string[] arr, int lengte)
{
  foreach (string n in arr)
  {
  if (n.Length == lengte)
  return n;
  }
  return null;
}
 //Main
  static void Main()
  {
     string[] namen = {"Elias", "Fatima", "Noah", "Aisha", "Liam", "Sofia", "Kenji", "Mila", "Omar", "Yara"};
	 
	 while (true)
	{
	 Console.WriteLine("--- MENU ---");
	 Console.WriteLine("a. Controleer of naam bestaat");
	 Console.WriteLine("b. Zoek volgnummer van naam");
	 Console.WriteLine("c. Zoek naam op woord");
	 Console.WriteLine("d. Zoek naam op lengte");
	 Console.WriteLine("e. Afsluiten");
	 Console.WriteLine();
	 Console.Write("Maak een keuze: ");
	 
	 string keuze = Console.ReadLine();
	 Console.WriteLine();
	 
	if (keuze == "a")
	 {
	 Console.Write("Naam: ");
	 string naam = Console.ReadLine();
	 
	if (NaamBestaat(namen,naam))
	 Console.WriteLine($"'{naam}' komt voor in de lijst");
	else
	 Console.WriteLine($"'{naam}' komt niet voor in de lijst");
	 }
	else if (keuze == "b")
	 {
	 Console.Write("Naam: ");
	 string naam = Console.ReadLine();
	 
	 int? pos = ZoekVolgnummer(namen, naam);
	 if (pos == null)
	   Console.WriteLine($"'{naam}' is niet gevonden");
	else
	   Console.WriteLine($"'{naam}' is  gevonden op positie {pos}");
	  }
	else if (keuze == "c")
	  {
	  Console.Write("Zoekwoord: ");
	  string woord = Console.ReadLine();
	  
	  string resultaat = ZoekOpWoord(namen, woord);
	  
	if (resultaat == null)
	  Console.WriteLine($"geen naam gevonden voor '{woord}'");
    else
      Console.WriteLine($"'{resultaat}' gevonden voor '{woord}'");
     }
    else if (keuze == "d")
      {
      Console.Write("Lengte: ");
      int lengte = int.Parse(Console.ReadLine());
	  
	  string resultaat = ZoekOpLengte(namen, lengte);
	  if (resultaat == null)
	    Console.WriteLine($"geen naam gevonden met {lengte}");
	  else
	    Console.WriteLine($"naam met {lengte}: {resultaat}");
	}
	else if (keuze == "e")
	{
	  break;
	}
    Console.WriteLine();	  
    }
  }
}
	 
	 
	 
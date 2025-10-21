using System;

namespace ConsoleRadenGrenzen
{
class Program
{
static void Main ()
  {
    Console.WriteLine(@" 
	____  ____  ____  _____ _     
/  __\/  _ \/  _ \/  __// \  /|
|  \/|| / \|| | \||  \  | |\ ||
|    /| |-||| |_/||  /_ | | \||
\_/\_\\_/ \|\____/\____\\_/  \|
");

	Console.WriteLine("Geef een ondergrens: ");
	int ondergrens = int.Parse(Console.ReadLine());
	
	Console.WriteLine("Geef een bovengrens: ");
	int bovengrens = int.Parse(Console.ReadLine());
	
	if (bovengrens < ondergrens)
	{
	    int tmp = ondergrens;
		ondergrens = bovengrens;
		bovengrens = tmp;
	}
	Random rnd = new Random();
	int geheimGetal = rnd.Next(ondergrens +1, bovengrens);
	
	Console.WriteLine($"Ik heb een getal tussen {ondergrens} en {bovengrens} in mijn hoofd.");
	Console.Write("Doe een gok: ");
	int gok = int.Parse(Console.ReadLine());
	
	if (gok == geheimGetal)
	{
	Console.ForegroundColor = ConsoleColor.Green;
	Console.WriteLine("JUIST!");
	}
	else
	{
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine("FOUT!");
	if (Math.Abs(gok - geheimGetal) <= 2)
	{
	Console.ResetColor();
	Console.WriteLine("Je zat er nochtans niet ver af!");
   }
 }
	Console.ResetColor();
                               
  } 
 }
}
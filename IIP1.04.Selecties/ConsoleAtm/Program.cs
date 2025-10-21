using System;

namespace ConsoleAtm
{
class Program
{
    static void Main()
	{

        const int MAX_BEDRAG = 200;
		double saldo = 500;
  
  string header = """
Bankautomaat
============
""";
  
  Console.WriteLine(header);
   Console.WriteLine($"huidig saldo: {saldo:C}\n");
    Console.WriteLine("a. afhaling");
    Console.WriteLine("b. storting");
    Console.WriteLine("c. stoppen\n");

        Console.Write("je keuze: ");
        char keuze = Char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (keuze)
        {
            case 'a':
                Console.Write("\nwelk bedrag wil je afhalen: ");
                if (!double.TryParse(Console.ReadLine(), out double bedrag))
                {
                    Console.WriteLine("fout: ongeldig bedrag");
                    break;
                }

                if (bedrag <= 0)
                {
                    Console.WriteLine("fout: bedrag moet positief zijn");
                }
                else if (bedrag > Math.Min(MAX_BEDRAG, saldo))
                {
                    Console.WriteLine($"fout: je kan maximaal {Math.Min(MAX_BEDRAG, saldo)} afhalen");
                }
                else if (bedrag % 10 != 0 || bedrag == 10 || bedrag == 30)
                {
                    Console.WriteLine("fout: enkel briefjes van 20 en 50 zijn mogelijk");
                }
                else
                {
                    saldo -= bedrag;
                    Console.WriteLine($"\nafhaling ok – het nieuw saldo is {saldo:C}");
                }
                break;

            case 'b':
                Console.Write("\nwelk bedrag wil je storten: ");
                if (!double.TryParse(Console.ReadLine(), out double storting))
                {
                    Console.WriteLine("fout: ongeldig bedrag");
                    break;
                }
                saldo += storting;
                Console.WriteLine($"\nstorting ok – het nieuw saldo is {saldo:C}");
                break;

            case 'c':
                Console.WriteLine("\nbedankt en tot ziens");
                break;

            default:
                Console.WriteLine("\nongeldige keuze");
                break;
	  }
   }
  }
}
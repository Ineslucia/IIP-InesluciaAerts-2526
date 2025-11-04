using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        decimal saldo = 1000m;
        bool stoppen = false;
        CultureInfo nl = CultureInfo.GetCultureInfo("nl-NL");

        Console.WriteLine("Bankautomaat");
        Console.WriteLine("============");
        Console.WriteLine();
        Console.WriteLine($"Huidig saldo: {saldo.ToString("C", nl)}");
        Console.WriteLine();
        Console.WriteLine("a. afhaling");
        Console.WriteLine("b. storting");
        Console.WriteLine("c. stoppen");
        Console.WriteLine();

        while (!stoppen)
        {
            Console.Write("Je keuze: ");
            string keuze = Console.ReadLine();
            Console.WriteLine();

            switch (keuze)
            {
                case "a":
                    Console.Write("Welk bedrag wil je afhalen: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal afhaling))
                    {
                        if (afhaling % 20 != 0 && afhaling % 50 != 0)
                        {
                            Console.WriteLine("Fout: enkel briefjes van 20 en 50 zijn mogelijk");
                        }
                        else
                        {
                            saldo -= afhaling;
                            Console.WriteLine($"Afhaling ok – het nieuw saldo is {saldo.ToString("C", nl)}");
                        }
                    }
                    Console.WriteLine();
                    break;

                case "b":
                    Console.Write("Welk bedrag wil je storten: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal storting))
                    {
                        saldo += storting;
                        Console.WriteLine($"Storting ok – het nieuw saldo is {saldo.ToString("C", nl)}");
                    }
                    Console.WriteLine();
                    break;

                case "c":
                    stoppen = true;
                    Console.WriteLine("Bedankt en tot ziens!");
                    break;

                default:
                    Console.WriteLine("Ongeldige keuze, probeer opnieuw.");
                    Console.WriteLine();
                    break;
            }
        }
    }
}


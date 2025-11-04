using System;

class Program
{
    static void Main()
    {
        double som = 0;
        string invoer;

        while (true)
        {
            Console.Write("Voer een getal in (q om te stoppen): ");
            invoer = Console.ReadLine();

            if (invoer.ToLower() == "q")
            {
                break;
            }

            // omzetten naar getal
            if (double.TryParse(invoer, out double getal))
            {
                som += getal;
            }
            else
            {
                Console.WriteLine("Ongeldige invoer, probeer opnieuw.");
            }
        }

        Console.WriteLine($"De som is: {som}");
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("BEREKEN GROOTST GEMENE DELER");
        Console.WriteLine("=============================");

        Console.Write("Getal 1: ");
        int getal1 = int.Parse(Console.ReadLine());

        Console.Write("Getal 2: ");
        int getal2 = int.Parse(Console.ReadLine());

        // Algoritme van Euclides met while-lus
        while (getal1 != getal2)
        {
            if (getal1 > getal2)
            {
                getal1 = getal1 - getal2;
            }
            else
            {
                getal2 = getal2 - getal1;
            }
        }

        Console.WriteLine($"De grootst gemene deler is: {getal1}");
    }
}

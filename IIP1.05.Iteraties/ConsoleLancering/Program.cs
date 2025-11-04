using System;

class Program
{
    static void Main()
    {
        Console.Write("Hoeveel seconden tot lancering? ");
        int seconden = int.Parse(Console.ReadLine());

        // --- For-versie ---
        Console.WriteLine("\nfor-versie:");
        for (int i = seconden; i > 0; i--)
        {
            Console.WriteLine($"{i}...");
        }
        Console.WriteLine("Lift off!");

        // --- Do-while-versie ---
        Console.WriteLine("\ndo-while versie:");
        int j = seconden;
        do
        {
            Console.WriteLine($"{j}...");
            j--;
        } while (j > 0);
        Console.WriteLine("Lift off!");

        // --- While-versie ---
        Console.WriteLine("\nwhile versie:");
        int k = seconden;
        while (k > 0)
        {
            Console.WriteLine($"{k}...");
            k--;
        }
        Console.WriteLine("Lift off!");
    }
}

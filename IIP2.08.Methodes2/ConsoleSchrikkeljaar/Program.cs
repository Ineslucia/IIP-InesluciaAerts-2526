using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("SCHRIKKELJAAR");
        Console.WriteLine("==============");

        int jaar;

        do
        {
            Console.Write("Geef een jaartal: ");
            jaar = int.Parse(Console.ReadLine());

            if (jaar > 0)
            {
                if (IsSchrikkeljaar(jaar))
                {
                    Console.WriteLine("Het jaar " + jaar + " is een schrikkeljaar.");
                }
                else
                {
                    Console.WriteLine("Het jaar " + jaar + " is geen schrikkeljaar.");
                }
            }

        } while (jaar > 0);

        Console.WriteLine();
        Console.WriteLine("Bedankt en tot ziens.");
    }

    static bool IsSchrikkeljaar(int jaar)
    {
        return (jaar % 4 == 0 && jaar % 100 != 0) || (jaar % 400 == 0);
    }
}

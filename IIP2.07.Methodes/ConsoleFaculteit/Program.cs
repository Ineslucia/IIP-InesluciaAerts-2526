using System;

class Program
{
   static void Main(string[] args)
   {
    Console.WriteLine("FACULTEIT BEREKENEN\n");

    Console.Write("Geef een geheel getal: ");
    int getal = int.Parse(Console.ReadLine());

    int faculteit = Faculteit(getal);

    Console.WriteLine($"De faculteit is {faculteit}");

   }
   
   private static int Faculteit(int n)
{
    int resultaat = 1;

    for (int i = 1; i <= n; i++)
    {
        resultaat *= i;
    }

    return resultaat;
}

}
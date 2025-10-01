using System;

public class Class1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welkom in de echoput");
        Console.Write("Zeg iets: ");
        string echo = Console.ReadLine();
        Console.Write($"{echo}! {echo}! {echo}!");
    }
}

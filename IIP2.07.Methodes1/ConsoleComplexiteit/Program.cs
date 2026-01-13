using System;

class Program
{
static bool IsKlinker(char c)
{
    char lower = char.ToLower(c);
    return "aeiou".Contains(lower);
}

static int AantalLettergrepen(string woord)
{
    int lettergrepen = 0;
    bool vorigeWasKlinker = false;

    foreach (char c in woord)
    {
        if (IsKlinker(c))
        {
            if (!vorigeWasKlinker)
            {
                lettergrepen++;
                vorigeWasKlinker = true;
            }
        }
        else
        {
            vorigeWasKlinker = false;
        }
    }

    return lettergrepen;
}

static double Complexiteit(string woord)
{
    int aantalLetters = woord.Length;
    int lettergrepen = AantalLettergrepen(woord);
    double score = aantalLetters / 3.0 + lettergrepen;

    string lower = woord.ToLower();
    if (lower.Contains('q')) score += 1;
    if (lower.Contains('x')) score += 1;
    if (lower.Contains('y')) score += 1;

    return Math.Round(score, 1);
  }
  static void Main(string[] args)
{
    while (true)
    {
        Console.Write("Geef een woord (enter om te stoppen): ");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Bedankt en tot ziens.");
            break;
        }

        int aantalLetters = input.Length;
        int lettergrepen = AantalLettergrepen(input);
        double complexiteit = Complexiteit(input);

        Console.WriteLine($"- aantal karakters: {aantalLetters}");
        Console.WriteLine($"- aantal lettergrepen: {lettergrepen}");
        Console.WriteLine($"- complexiteit: {complexiteit}");
        Console.WriteLine();
    }
}

}

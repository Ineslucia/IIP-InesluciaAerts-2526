using System;

class Program
{
    static void Main()
    {
        Console.Write("Geef een tekst: ");
        string tekst = Console.ReadLine();

        int spaties = AantalSpaties(tekst);
        int klinkers = AantalKlinkers(tekst);
        string geheim = NaarGeheimschrift(tekst);

        Console.WriteLine($"deze tekst bevat {klinkers} klinkers en {spaties} spaties");
        Console.WriteLine($"in geheimschrift: {geheim}");
    }

    static int AantalSpaties(string input)
    {
        int count = 0;
        foreach (char c in input)
        {
            if (c == ' ')
            {
                count++;
            }
        }
        return count;
    }

    static int AantalKlinkers(string input)
    {
        int count = 0;
        foreach (char c in input)
        {
            char lower = char.ToLower(c); // converteer hoofdletter naar kleine letter
            if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
            {
                count++;
            }
        }
        return count;
    }

    static string NaarGeheimschrift(string input)
    {
        string resultaat = "";
        foreach (char c in input)
        {
            if (c == ' ')
            {
                resultaat += ' ';
            }
            else
            {
                resultaat += (char)(c + 1);
            }
        }
        return resultaat;
    }
}


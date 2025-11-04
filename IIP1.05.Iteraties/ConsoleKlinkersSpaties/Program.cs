using System;

class Program
{
    static void Main()
    {
        Console.Write("Geef een tekst: ");
        string input = Console.ReadLine();

        int aantalKlinkers = 0;
        int aantalSpaties = 0;
        string geheimSchrift = "";

        foreach (char c in input)
        {
            // Klinkers tellen (zowel hoofd- als kleine letters)
            if (c == 'a' || c == 'A' ||
                c == 'e' || c == 'E' ||
                c == 'i' || c == 'I' ||
                c == 'o' || c == 'O' ||
                c == 'u' || c == 'U')
            {
                aantalKlinkers++;
            }

            // Spaties tellen
            if (c == ' ')
            {
                aantalSpaties++;
            }

            // Geheimschrift: elke letter + 1 opschuiven
            char nieuwChar = c;
            if (c >= 'A' && c <= 'Z') // hoofdletters
            {
                nieuwChar = (char)(c == 'Z' ? 'A' : c + 1);
            }
            else if (c >= 'a' && c <= 'z') // kleine letters
            {
                nieuwChar = (char)(c == 'z' ? 'a' : c + 1);
            }

            geheimSchrift += nieuwChar;
        }

        Console.WriteLine($"Deze tekst bevat {aantalKlinkers} klinkers en {aantalSpaties} spaties");
        Console.WriteLine($"In geheimschrift: {geheimSchrift}");
    }
}

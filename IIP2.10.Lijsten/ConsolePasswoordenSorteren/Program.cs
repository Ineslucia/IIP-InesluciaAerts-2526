using System;

class Program
{
    static void Main()
    {
//vaste array van paswoorden
        string[] paswoorden =
        {
            "klepktoe",
            "test",
            "Azerty123",
            "rogier@work",
            "password",
            "MisterNasty12",
            "pwnz0red"
        };

//twee arrays (maximale grootte = aantal paswoorden)
        string[] ok = new string[paswoorden.Length];
        string[] nietOk = new string[paswoorden.Length];

        int okCount = 0;
        int nietOkCount = 0;
		
//Overloop elke passwoord in de array
        Console.WriteLine("Alle paswoorden:");
        for (int i = 0; i < paswoorden.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {paswoorden[i]}");

            if (IsCorrectPaswoord(paswoorden[i]))
            {
                ok[okCount++] = paswoorden[i];
            }
            else
            {
                nietOk[nietOkCount++] = paswoorden[i];
            }
        }

        Console.WriteLine();
//string.Join maakt van de array één string gescheiden door ","
// okCount om lege plaatsen niet af te drukken
        Console.WriteLine("Ok: " + string.Join(", ", ok, 0, okCount));
        Console.WriteLine("Niet ok: " + string.Join(", ", nietOk, 0, nietOkCount));
    }
//Methode die controleert of een passwoord voldoet aan alle regels
    static bool IsCorrectPaswoord(string paswoord)
    {
        if (paswoord.Length < 8)
            return false;

        if (paswoord.Contains("@"))
            return false;

        if (paswoord == "123456789" || paswoord == "password" || paswoord == "Azerty123")
            return false;

        return true;
    }
}

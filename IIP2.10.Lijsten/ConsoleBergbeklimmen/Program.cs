using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> hoogtes = new List<int>();
        int invoer;

    // Hoogtes inlezen tot gebruiker 0 invoert
        do
        {
            Console.Write("Voer een hoogtemeting in (in m): ");
            invoer = int.Parse(Console.ReadLine());
            if (invoer != 0)
            {
                hoogtes.Add(invoer);
            }
        } while (invoer != 0);

// bereken alle hoogteverschillen (stijgingen en dalingen)
        int[] stijgingen = BerekenStijgingen(hoogtes);
		
//toon alle stijgingen zn dalingen op het scherm
        Console.Write("Stijgingen: ");
        for (int i = 0; i < stijgingen.Length; i++)
        {
            Console.Write(stijgingen[i]);
            if (i < stijgingen.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine(" meter");
        Console.WriteLine();
		
//bepaal de grootste positieve stijging
        int sterkste = BerekenSterksteStijging(stijgingen);
        int totale = BerekenTotaleStijging(stijgingen);

//bereken de totale stijging (som van alle positieve stijgingen)
        Console.WriteLine("De hoogste helling is " + sterkste + " meter");
        Console.WriteLine("De totale stijging is " + totale + " meter");
    }

//Methode die alle hoogteverschillen berekent
    static int[] BerekenStijgingen(List<int> hoogtes)
    {
//array voor het opslaan v.d verschillende tussen opeenvolgende hoogtes	
        int[] stijgingen = new int[hoogtes.Count - 1];

        for (int i = 0; i < hoogtes.Count - 1; i++)
        {
            stijgingen[i] = hoogtes[i + 1] - hoogtes[i];
        }

        return stijgingen;
    }

//Methode die de sterkste stijging bepaalt (enkel positieve waarden)
    static int BerekenSterksteStijging(int[] stijgingen)
    {
        int max = 0;

        foreach (int s in stijgingen)
        {
            if (s > max)
            {
                max = s;
            }
        }

        return max;
    }

//Methode die de totale stijging berekent (som van positieve stijgingen)
    static int BerekenTotaleStijging(int[] stijgingen)
    {
        int totaal = 0;

        foreach (int s in stijgingen)
        {
            if (s > 0)
            {
                totaal += s;
            }
        }

        return totaal;
    }
}

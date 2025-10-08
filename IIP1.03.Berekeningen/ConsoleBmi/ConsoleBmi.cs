using System;

namespace ConsoleBmi
{
  class Program
  {
    static void Main(string[]args)
	{
		Console.WriteLine("BMI CALCULATOR");
		Console.WriteLine("==============");
		
		Console.Write("Lengte (in cm): ");
		int lengteInCm = Console.ReadLine();
		
		Console.Write("Gewicht (in kg): ");
		int gewichtInKg = Console.ReadLine();
		
		double lengteInM = lengteInCm /100.0;
		double bmi = gewichtInKg / (lengteInM * lengteInM) Math.Round(,1);
		
		Console.Write($"Je BMI bedraagt: ");
	}
  }
}
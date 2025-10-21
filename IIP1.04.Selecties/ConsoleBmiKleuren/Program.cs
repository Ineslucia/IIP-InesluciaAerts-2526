using System;
namespace ConsoleBmiKleuren
{
class Program
{
static void Main(string[] args)
  {
  Console.WriteLine("BMI CALCULATOR");
            Console.WriteLine("==============");

            Console.Write("Lengte (in cm): ");
            int lengteInCm = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gewicht (in kg): ");
            int gewichtInKg = Convert.ToInt32(Console.ReadLine());

            double lengteInM = lengteInCm / 100.0;
            double bmi = gewichtInKg / (lengteInM * lengteInM);
            double afgerondBmi = Math.Round(bmi, 1);
            
             Console.WriteLine($"Je BMI bedraagt: {afgerondBmi}");
             
             
             if (afgerondBmi < 18.5)
             {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Je hebt ondergewicht");
            }
            else if (afgerondBmi >= 18.5 && afgerondBmi < 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Je gewicht is normaal");
            }
            else if (afgerondBmi >= 25 && afgerondBmi < 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Je hebt obesitas");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Je hebt obesitas");
            }
            
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
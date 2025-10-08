/*
 * Auteur: Inés Aerts
 * Datum: 2025-09-024
 */
using System;

namespace ConsoleHelloWereld
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Hello Wereld!");
		 Console.Write("Hoe heet je? :");
		 string naam = Console.ReadLine();
		 
		 Console.ForegroundColor = ConsoleColor.Yellow;
		 Console.WriteLine($"Aangenaam kennismaking {naam}");
		 
		 Console.ResetColor();
		 Console.WriteLine("druk een toets om verder te gaan...");
		 Console.ReadKey(true);
        
      }
   }
}

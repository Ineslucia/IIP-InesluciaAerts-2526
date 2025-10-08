using System;

namespace ConsoleGangsterName
{
   class Program
   {
      static void Main(string[] args)
      {
	  
	        string header = @"
***********************
| GANGSTA NAME BUILDER |
***********************
";
        Console.WriteLine(header);
		
        Console.Write("Give the first name of any Disney character: ");
		string character = Console.ReadLine();
		
		Console.Write("Give any workbench tool: ");
		string tool = Console.ReadLine();
		
		Console.Write("What is your last name: ");
		string lastName = Console.ReadLine();
		
		string gangsterName = character + " '" + tool + "' " + lastName;
		
		Console.Write("Your gangster name: ");
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine(gangsterName);
		
		 Console.ResetColor();
        
      }
   }
}
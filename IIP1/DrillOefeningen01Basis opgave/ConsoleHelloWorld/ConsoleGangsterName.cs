using System;

namespace ConsoleHelloWorld
{
   class Program ConsoleGangsterName
   {
      static void Main(string[] args)
      {
	  
	  string header = $@"******************************
                       **| GANGSTA NAME BUILDER |
                       ******************************";
	  
	  Console.WriteLine(header);	  
	    Console.WriteLine{"Give the first name of any Disney character: "};
		string disneyCharacter = Console.ReadLine();
		
		Console.WriteLine{"Give any workbench tool: "};
		string workTool = Console.ReadLine();
		
		Console.WriteLine{"what is your last name: "}
		string lastName = Console.ReadLine();
		
		string gangsterName = disneyCharacter + 'workTool' + lastName;
		Console.ForegroundColor = ConsoleColor.Green; 
		Console.WriteLine{$"Your gangsta name: {disneyCharacter} '{workTool}' {lastName}"};
	  
	    }
	}
}
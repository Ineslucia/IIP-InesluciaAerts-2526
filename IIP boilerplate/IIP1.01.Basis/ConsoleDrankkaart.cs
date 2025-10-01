using System;

namespace ConsoleDrankkaart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            
            Console.WriteLine("@====== MENU ======");
            Console.WriteLine("☕ Koffie:   3€");
            Console.WriteLine("🍵 Thee:    2€");
            Console.WriteLine("🥤 Limo:    2€");
            Console.WriteLine("-------------------");
            Console.WriteLine("copyright ©2025\n");

            string pad = @"C:\Dropbox\MijnCafe\menu.pdf";
            Console.WriteLine($"Het menu staat ook op \"{pad}\"");
        }
    }
}


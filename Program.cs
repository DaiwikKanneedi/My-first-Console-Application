using System;

namespace Daiwik__First_Console_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Daiwik's First Console";
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("Hello Whats Your Name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello "+ userName+" Nice to meet You");
            Console.ReadLine();
            Console.WriteLine("so What's Your Intreasted In?");
            string IntreastedIn = Console.ReadLine();
            Console.WriteLine("OH HO HO HO "+IntreastedIn+" hmmmm I Don't Know "+IntreastedIn+" So I think I cannot help you");  
            Console.WriteLine("Message If you Press any Key The console will be close");
            Console.ReadKey();
        }
    }
}
using System;

namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string applicationName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Mohamad Kareem";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", applicationName, appVersion, appAuthor);

            Console.ResetColor();

            //Ask user name
            Console.WriteLine("Enter your name:");

            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets start...!!", input);

        }
    }
}

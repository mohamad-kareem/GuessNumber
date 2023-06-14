using System;

namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            gameinfo();
            userinfo();
            while (true)
            {

            
            Random random = new Random();
            int correctNumber=random.Next(1,10);
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");
            
            while (guess != correctNumber)
            {
                string input = Console.ReadLine();
                if(!int.TryParse(input, out guess))
                {
                   color(ConsoleColor.Red,"Wrong input!!, please enter a number");
                    continue;
                }

                guess = Int32.Parse(input);

                if (guess != correctNumber)
                {
                        color(ConsoleColor.Red, "Wrong guess please try again");
                        
                }
            }
                color(ConsoleColor.Yellow, "Great you are guessed the number");
              

            Console.WriteLine("Play Again [Y or N]");

            string answer =Console.ReadLine().ToUpper();
            if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N") {
                    return;
                }
               
            }
        }

        static void gameinfo()
        {
            string applicationName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Mohamad Kareem";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", applicationName, appVersion, appAuthor);

            Console.ResetColor();
        }

        static void userinfo()
        {
            Console.WriteLine("Enter your name:");

            string Name = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets start...!!", Name);
        }
        static void color(ConsoleColor color,string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

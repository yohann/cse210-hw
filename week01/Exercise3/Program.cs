using System;

class Program
{
    static void Main()
    {
        string playAgain = "yes";
        
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            
            int guess = -1;
            int guessCount = 0;
            
            Console.WriteLine("Welcome to Guess My Number!");
            
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine() ?? "0";
                guess = int.Parse(input);
                guessCount++;
                
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }
            
            // Ask if they want to play again
            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine() ?? "no";
            
        } while (playAgain.ToLower() == "yes");
        
        Console.WriteLine("Thanks for playing!");
    }
}
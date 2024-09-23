using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")

        {
            Console.Write("Enter a magic number: ");
            int MagicNumber = int.Parse(Console.ReadLine());

            int guessCount = 0;
            int guess = 0;

            while (guess != MagicNumber)
            {
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;
        

                if (guess > MagicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess < MagicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else 
                {
                    Console.WriteLine($"Awsome! You guessed right It took you {guessCount} attempts.");
                }
            }

            Console.WriteLine("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }
    }    
}
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Guess My Number (1–100) ===");

        while (true)
        {
            Random rng = new Random();
            int magic = rng.Next(1, 101);

            int attempts = 0;
            int guess = 0;

            while (true)
            {
                guess = ReadInt("What is your guess? ");

                attempts++;

                if (guess < magic)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magic)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"Guesses: {attempts}");
                    break;
                }
            }
        }
    }
}
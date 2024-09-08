using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101); // Random number between 1 and 100
        int userGuess;
        int guessCount = 0;

        Console.WriteLine("Guess the number between 1 and 100!");

        do
        {
            Console.Write("Enter your guess: ");
            userGuess = Convert.ToInt32(Console.ReadLine());
            guessCount++;

            if (userGuess < numberToGuess)
            {
                Console.WriteLine("Too low!");
            }
            else if (userGuess > numberToGuess)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("Congratulations! You've guessed the number.");
                Console.WriteLine("Total guesses: " + guessCount);
            }

        } while (userGuess != numberToGuess);

        Console.ReadLine();
    }
}
using System;

namespace CSharpPractice
{
    public static class Program
    {
        static void Main(string[] args)
        {

            RunNumberGuessingGame();

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();

        }

        // A function that generates a random number, which is set to a myMysteryNumber variable 
        // Player must use hints to guess the myMysteryNumber 

        private static void RunNumberGuessingGame()
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("I am thinking of a number between 1 and 25.");

            // Random number generator 
            Random rand = new Random();

            // Generate a random number between 1 and 15
            int myMysteryNumber = rand.Next(1, 26);

            // Initialise player guess
            int playerGuess = 0;

            // While loop controller 
            bool isGameRunning = true;

            while (isGameRunning)
            {
                Console.WriteLine("Please make your guess...");

                string input = Console.ReadLine(); // Reads the input as a string 
                playerGuess = int.Parse(input); // Converts string to integer 

                if (playerGuess == myMysteryNumber)
                {
                    Console.WriteLine($"You are correct, well done! {myMysteryNumber} is the mystery number!");
                    isGameRunning = false; // Break while loop
                }
                else if (playerGuess < myMysteryNumber)
                {
                    Console.WriteLine("Too low. Guess again.");
                }
                else if (playerGuess > myMysteryNumber)
                {
                    Console.WriteLine("Too high. Guess again.");
                }
            }
        }
    }
}
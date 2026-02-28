using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game! I am thinking of a number between 1 and 25.");
            
            Random rand = new Random(); // variable rand is an instance of the Random class

            int myMysteryNumber = rand.Next(1, 26); // generates a new random number between 1-25
            int playerGuess = -9999999; // initialising player guess 

            bool isGameRunning = true;

            while (isGameRunning == true)
            {
                Console.WriteLine("Please make your guess...");
                string input = Console.ReadLine(); // take in input as a string
                playerGuess = Convert.ToInt32(input); // update player guess with the converted input

                if (playerGuess == myMysteryNumber)
                {
                    Console.WriteLine($"You are correct, well done! {myMysteryNumber} is the mystery number!");
                    isGameRunning = false; // end while loop
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
using System;

namespace SmallCalculator
{
    public static class Program
    {
        static void Main(string[] args)
        {

            // while running boolean to break 
            // display choices 
            // input of what function to use 
            // run associated function 

            // required functions 
            // add 
            // subtract 
            // multiply 
            // divide 
            // Leave game - "q"
            // Invalid choice - check input

            DisplayChoices();
        }
            

        private static void DisplayChoices()
        {
            Console.WriteLine(" ____ Welcome to the Simple Calculator ____\n");
            Console.WriteLine("You have the following choices:");
            Console.WriteLine("To add - enter 1");
            Console.WriteLine("To subtract - enter 2");
            Console.WriteLine("To multiply - enter 3");
            Console.WriteLine("To divide - enter 4");
            Console.WriteLine("To leave the program, enter \"q\"");
        }











        }
    }


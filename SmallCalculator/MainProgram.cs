using System;
using System.ComponentModel;
using System.Numerics;

namespace SmallCalculator
{
    public static class MainProgram
    {
        static void Main(string[] args)
        {
            bool gameRunning = true;

            while (gameRunning)
            {
                DisplayChoices();

                string playerChoice = Console.ReadLine();
                if (ValidateInput(playerChoice))
                {
                    switch (playerChoice)
                    {
                        case "1":
                            Add();
                            break;

                        case "2":
                            Subtract();
                            break;

                        case "3":
                            Multiply();
                            break;

                        case "4":
                            Divide();
                            break;
                    }
                }


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


            }
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

        private static void ValidateInput(playerChoice)
        {
            if (playerChoice = "q") {
                Console.WriteLine("Goodbye. Press any key to exit.");
                Console.ReadKey();

                gameRunning = false;
            }

            
        }












        }
    }


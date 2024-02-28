using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */

            
            // these are here to create the testing game object, the game object and a boolean for the while loop
            Testing testing = new Testing();
            bool RollAgain = true;
            Game game = new Game();
            
            // this calling the testing method
            testing.Dietesting();

            while (RollAgain == true) // this while loop allows the user to decide if they will roll again
            {
                Console.WriteLine("Roll again? Enter y or n:");

                string choice = Console.ReadLine();

                // this if statment is here to help decide what will happen depending on the player input
                if (choice == "y")
                {
                    game.ReRollDie(); // this calls the game method for rerolling
                    RollAgain = true; // this continues the loop
                }

                else if (choice == "n")
                {
                    Console.WriteLine("End of program, press any key to exit.");
                    RollAgain = false; // this discontinues the loop
                }

                else
                {
                    Console.WriteLine("That isn't a valid choice, choose again. y or n.");
                    RollAgain = true; // this gives the user another chance to put in the right input incase it was an error on their behalf
                }
            }

            Console.ReadLine(); // this makes sure that the console window stays open

        }
            
    }
}

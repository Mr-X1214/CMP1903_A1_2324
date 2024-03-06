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


            
            // these are here to create the testing game object and a boolean for the while loop
            Testing testing = new Testing();
            bool rollAgain = true;
            
            // this calling the testing method
            testing.DieTesting();

            while (rollAgain == true) // this while loop allows the user to decide if they will roll again
            {
                Console.WriteLine("Roll again? Enter y or n:");

                string choice = Console.ReadLine();

                // this if statment is here to help decide what will happen depending on the player input
                if (choice == "y")
                {
                    testing.DieTesting(); // this calls the testing method so they can reroll
                    rollAgain = true; // this continues the loop
                }

                else if (choice == "n")
                {
                    Console.WriteLine("End of program, press any key to exit.");
                    rollAgain = false; // this discontinues the loop
                }

                else
                {
                    Console.WriteLine("That isn't a valid choice, choose again. y or n.");
                    rollAgain = true; // this gives the user another chance to put in the right input
                }
            }

            Console.ReadLine(); // this makes sure that the console window stays open

        }
            
    }


}

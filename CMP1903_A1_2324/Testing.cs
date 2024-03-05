using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method

        
        // this creates the game and die game object
        Game TestGame = new Game();
        Die TestDie = new Die();

        // this is used to do the testing so I can easily call the function
        public void DieTesting()
        {
            int[] Values = TestGame.DieRolling(); // this creates an array so I can use it to hold the value of the dice roll total
            
            // this if for testing the dice rolls
            Console.WriteLine("Testing the dice rolls.");
            // this creates a dice roll to test
            TestDie.Roll();
            Debug.Assert(TestDie.Roll() > 0); // this and the one bellow tests that it's within a specific range
            Debug.Assert(TestDie.Roll() < 7);
            Console.WriteLine("Test of the dice rolls complete.");
            int testSum = Values[0]; // this stores the sum of the dice rolls into the array

            // this tests the sum of the dice rolls
            Console.WriteLine("Testing sum of dice rolls.");
            Debug.Assert(testSum > 2); // this and the one below tests that the sum of the dice rolls is within a specific range
            Debug.Assert(testSum < 19);
            Console.WriteLine("Testing sum of dice complete.");

            Console.WriteLine("All testing successful");

            // this makes sure that the variable returns to 0 after the testing is done so that it doesn't store the value and keeping adding it on
            TestGame.sumOfdie = 0;

        }
        
    }
}

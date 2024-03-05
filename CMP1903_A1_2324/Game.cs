using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using System.Threading;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */


        // creates a variable for the sum of the dice to be stored in for game object method
        public int sumOfdie = 0;

        //methods

        // this creates the 3 dice
        Die Die1 = new Die();
        Die Die2 = new Die();
        Die Die3 = new Die();


        // this creates the array for the values to be stored in
        public int[] DieRolling() 
        {
            Die1.Roll(); // this rolls the first die
            Thread.Sleep(2); // this creates a delay so that it has enough time to truly randomise the next output

            Die2.Roll(); // this rolls the second die
            Thread.Sleep(2); // this is another delay

            Die3.Roll(); // this rolls the last die and doesn't need a delay

            // this stores the value of the rolls in seperate variables so it can be eaisly together
            int die1Val = Die1.dieValue;
            int die2Val = Die2.dieValue;
            int die3Val = Die3.dieValue;

            // this adds the rolls together and stores it in that variable
            sumOfdie += die1Val + die2Val + die3Val; 
            
            // this prints out the different values so that the user can see it
            Console.WriteLine("The values of the 3 dice rolls:");
            Console.WriteLine(die1Val);
            Console.WriteLine(die2Val);
            Console.WriteLine(die3Val);
            Console.WriteLine("The sum of all dice is:");
            Console.WriteLine(sumOfdie);

            // this stores the value of the rolls added together and then returns it
            int[] values = { sumOfdie };
            return values;

        }
            
        
           
    }
}

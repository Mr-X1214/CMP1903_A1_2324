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


        // creates a variable for the sum of the dice to be stored in for the main one and the rerolling
        public int sum_of_die = 0;
        int ReRollVal = 0;

        //methods

        // this creates the 3 dice
        Die Die1 = new Die();
        Die Die2 = new Die();
        Die Die3 = new Die();



        public int[] dierolling() // this creates the array for the values ot be stored in
        {
            Die1.Roll(); // this rolls the first die
            Thread.Sleep(2); // this creates a delay so that it has enough time to truly randomise the next output

            Die2.Roll(); // this rolls the second die
            Thread.Sleep(2); // this is another delay

            Die3.Roll(); // this rolls the last die and doesn't need a delay

            // this stores the value of the rolls in seperate variables so it can be eaisly together
            int Die1val = Die1.die_value;
            int Die2val = Die2.die_value;
            int Die3val = Die3.die_value;

            sum_of_die += Die1val + Die2val + Die3val; // this adds the rolls together and stores it in that variable
            
            // this prints out the different values so that the user can see it
            Console.WriteLine("The values of the 3 dice rolls:");
            Console.WriteLine(Die1val);
            Console.WriteLine(Die2val);
            Console.WriteLine(Die3val);
            Console.WriteLine("The sum of all dice is:");
            Console.WriteLine(sum_of_die);

            // this stores the value of the rolls added together and then returns it
            int[] values = { sum_of_die };
            return values;
        }

        public void ReRollDie() // this here for the rerolling only it doesn't use an array, but it is the same as the game
        {
            Die1.Roll();
            Thread.Sleep(2);
            Die2.Roll();
            Thread.Sleep(2);
            Die3.Roll();

            int Die1val = Die1.die_value;
            int Die2val = Die2.die_value;
            int Die3val = Die3.die_value;

            ReRollVal += Die1val + Die2val + Die3val; // it uses this variable instead to store it so they are seperate

            Console.WriteLine("The values of the 3 dice rolls:");
            Console.WriteLine(Die1val);
            Console.WriteLine(Die2val);
            Console.WriteLine(Die3val);
            Console.WriteLine("The sum of all dice is:");
            Console.WriteLine(ReRollVal);

            ReRollVal = 0;
        }
            
        
           
    }
}

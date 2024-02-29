using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property


        // this creates the variable for the value of the die roll to be stored in
        public int die_value = 0;

        //Method
        public int Roll() // this is the method that rolls the dice
        {
            // creates the random
            Random rand = new Random();
            // gets the random number
            die_value = rand.Next(1, 7);

            // returns the value
            return die_value;
        }
    }
}

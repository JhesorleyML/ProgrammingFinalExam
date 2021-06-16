using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEamDemoProgram
{
    class PoolComparator
    {
        //store the numbers correctly guessed
        private List<int> resPool;
        public PoolComparator()
        {
            //initialize the pool of correctly guessed numbers
            resPool = new List<int>();
        }

        public int ComparePool(List<int> winningPool, List<int> guessPool)
        {
            //loops through the guessPool and compare its value one by one to the values of the winningPool
            foreach (var number in guessPool)
            {
                //compare the value of the guessPool to every values in the winningPool
                foreach (var winningNumber in winningPool)
                {
                    if (winningNumber == number)
                    {
                        //if guessed correctly, add that number to the resPool
                        //then terminate the loop to check the next number in the guessPool
                       /*
                        ------------- write your code in this line --------------------
                       */
                    }
                }
            }
            //show the numbers in the resPool
            /*
                ------------- write your code in this line --------------------
            */

            //return the count of numbers correctly guessed
            return this.resPool.Count;
        }

        private void ShowResultPool()
        {
            Console.WriteLine("\nNumbers correctly guessed");
            Console.Write("[ ");
            if (this.resPool.Count != 0)
            {   
                //loops through every value in the resPool and display on the console
                foreach (var num in resPool)
                {
                    /*
                        ------------- write your code in this line --------------------
                    */
                }
            }
            Console.WriteLine(" ]");
        }
    }
}

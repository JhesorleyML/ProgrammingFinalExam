using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEamDemoProgram
{
    class Program
    {
        //holds the guessed numbers of the users
        private static PoolGenerator guessPool;

        //determine the pool size and max limit
        //change this values if you want to change the pool size and range of numbers in the pool
        const int POOLSIZE = 10;
        const int MAXLIMIT = 100;

        //main method
        static void Main(string[] args)
        {
            //GuessPool
            //create and instance of Pool Generator as guessPool
            guessPool = new PoolGenerator(MAXLIMIT, POOLSIZE);
            GuessNumbers();
            Console.WriteLine("You bet on these numbers:");
            guessPool.DisplayNumbersPool();

            Console.WriteLine("\nAre you sure to show winning numbers now?");
            Console.Write("Press 'y' or 'Ý' to continue else 'n' or 'N' to terminate: ");
            try
            {
                char res = Convert.ToChar(Console.ReadLine());
                switch (res)
                {
                    case 'y':
                    case 'Y':
                        //generate the winning pool
                        //create and instance of Pool Generator as winningPool
                        PoolGenerator winningPool = new PoolGenerator(MAXLIMIT, POOLSIZE);
                        Console.WriteLine("\nWinning Numbers: ");

                        //generate the winning pool using the GenerateWinningPool() method
                        /*
                            ------------- write your code in this line --------------------
                        */

                        //compare the winning pool and the guess pool
                        //create and instance of Pool Comparator for comparing the guessPool and winningPool
                        PoolComparator comparator = new PoolComparator();

                        //use the ComparePool method to compare the values or numbers between two pools and also get the number of correct guess
                        int countOfCorrectGuess = comparator.ComparePool(winningPool.GetCurrentPool(), guessPool.GetCurrentPool());

                        //Display the no of correct guesses and those corresponding numbers
                        Console.Write(countOfCorrectGuess != 0 ? "Congratulations! " : "Sorry! ");
                        /*
                            ------------- write your code in this line --------------------
                        */
                        break;
                    case 'N':
                    case 'n':
                        /*
                            ------------- write your code in this line --------------------
                        */
                        break;
                    default:
                        Console.WriteLine("Invalid input. Application Terminated");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Selection");
            }
            Console.ReadKey();
        }

        //GuessNumbers() - Method for asking users numbers to be added to the guess pool
        static void GuessNumbers()
        {
            Console.WriteLine("Please guess {0} numbers from 1 to {1} to win.",POOLSIZE,MAXLIMIT);
            
            //fill the guess pool from users input
            for (int i = 1; i <= POOLSIZE; i++)
            {
                while (true)
                {
                    Console.Write("Guess {0} of {1}: ", i, POOLSIZE);
                    
                    //use try and catch to handle possible error/s of user input
                    try
                    {
                        //store the user input and convert it to integer
                        int a = Convert.ToInt32(Console.ReadLine());

                        //determine if the user input is within the given range of numbers
                        if ((a <= MAXLIMIT) && (a >= 1))
                        {
                            //if the guessed number is not yet in the pool then add the number to the pool and stop the loop
                            if (!guessPool.IsNumberExisted(a))
                            {
                                /*
                                    ------------- write your code in this line --------------------
                                */
                            }
                            //if the guessed number us already in the pool
                            else
                            {
                                Console.WriteLine("Number already in the guess pool. Select another number");
                            }
                        }
                        //if the user input is out of the given range or max limit
                        else
                        {
                            Console.WriteLine("Number out of range.");
                        }
                    }
                    catch (Exception)
                    {
                        //handle exception or errors if user input is not a number
                        Console.WriteLine("Invalid value. Input should be a number from the given range");
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            int[] Numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evens = new List<int>();
            var odds = new List<int>();


            Console.WriteLine("Evens or Odds");
            string Answer = Console.ReadLine();
            Answer = Answer.ToUpper();

            if (Answer == "EVENS")

            {

                for (int i = 0; i <= 100; i += 2)
                {
                    Console.WriteLine(i);
                    evens.Add(i);

                }
            }
            if (Answer == "ODDS")
            {
                for (int c = 1; c <= 100; c += 2)
                {
                    Console.WriteLine(c);
                    odds.Add(c);
                }

            }
            else
            {
                Console.WriteLine(Answer + " is not Odds or Evens so I will do them in order and tell you each one.");
                {
                    for(int a = 0; a <= 200; a++)
                    if(a % 2 == 0) 
                    {
                        evens.Add(a);
                        Console.WriteLine(a + " is even");
                    }
                    else if(a % 2 == 1)
                    {
                        odds.Add(a);
                        Console.WriteLine(a + " is odd");
                    }
                }
            }
        }
    }
}

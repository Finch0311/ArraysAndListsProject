using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:
                                                                        //done
            // Create an int Array and populate numbers 1-10
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };




            /* Create two Lists of type int.
             * Name one List "evens"                                    //done
             * Name the other List "odds"
             */
            var evens = new List<int>();

            var odds = new List<int>();

            foreach (int i in numbers)
            {
                

                if (i % 2 == 0)
                { evens.Add(i); }
                else { odds.Add(i); }
            }
            
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.                             //done
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (int i in odds)
            {
                Console.WriteLine(i);
            }

            foreach (int i in evens)
            {
                Console.Write(i);
            }
            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *                                                          //done
             * Try to be creative in your display       //unsure?
             */
        }
    }
}

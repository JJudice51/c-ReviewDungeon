using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {

        //create a fucntion that takes in 2 numbers and returns the smaller number
        int SmallNum(int a, int b)
        {
            if (a > b)
            {
                return b;
            }
            return a;
            //else if (a < b)
            //{
            //    return a;
            //}
            //else 
            //{
            //    return a;
            //}

            //Write a program that solves the FizzBuzz word game.
           // Given a number n, for each integer i in the range from 1 to n inclusive, print one value per line as follows:
           // If i is a multiple of both 3 and 5, print FizzBuzz.
          //  If i is a multiple of 3(but not 5), print Fizz.
          //  If i is a multiple of 5(but not 3), print Buzz.
          //  If i is not a multiple of 3 or 5, print the value of i.
           // The function must print the appropriate response for each value i in the set ...
           // { 1, 2, ... n} in ascending order, each on a separate line.
           void FizzBuzz(int n)
            {
                for (int i = 0; i < length; i++)
                {

                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
            }




        }
           

        public void Run()
        {
            Console.WriteLine(SmallNum(10, 3));






        }
    }
}

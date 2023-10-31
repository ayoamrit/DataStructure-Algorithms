using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Big_O
{
    internal class BigO
    {

        public BigO()
        {
            constant();
            linear();
            quadratic();
            logN();
            nLogN();

        }

        private void constant()
        {
            //Big-O(1) (Constant)
            //It is the princess standing on top of the castle that everybody wants.
            /*
            Assignment: int test = 0;
            Declaration: int test; 
            Arithmetic: 2+2;
            Comparison: 2 > x;
            Accessing Element: array[1];
            Calling Function: function(call);
             */

            int number = 15; //constant
            Console.WriteLine(number);  //constant
        }

        private void linear()
        {
            //Big-O(N) (Linear)
            //It is not bad, it's a Honda Civic, but not a Cadillac.
            /*
            Doing sone type of iteration. while or for loop.
            while(x > 5){ continue; }
             */

            //Linear
            for(int x = 0; x < 5; x++)
            {
                Console.WriteLine("Amrit");
            }
        }

        private void quadratic()
        {
            //Big-O(N^2) (Quadratic)
            //It is the one that you don't want or, in other words, use this if you wanna fail the interview
            /*
             * It is literally nested loops. Iterating through the iteration.
             */

            for(int x = 0; x < 5; x++)  //Time complexity is 'n' here.
            {
                for(int y = 0; y < 5; y++)  //Time complexity is 'n' here.
                {
                    Console.WriteLine("Amrit");


                    //'n' from outer loop and 'n' from the nested loop will be multiplied.
                    //Hence, leading to 'Quadratic' time complexity
                }
            }
        }

        private void logN()
        {
            //Binary Search and Trees
        }

        private void nLogN()
        {
            //Merge Sort, Quick Sort, Shell Sort, Cube Sort.
        }

    }
}

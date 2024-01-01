using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures___Algorithms.BinarySearch
{
    public class BSearch
    {

        public BSearch()
        {
            int[] numbers = { -12, -2, -2, 0, 2, 12, 31, 29, 61, 65, 79 };

            Console.WriteLine(BinarySearchHelper(numbers, 79));
        }

        private int BinarySearchHelper(int[] array, int targetValue)
        {
            //Starting point of the iteration
            int startPointer = 0;

            //End point of the iteration
            int endPointer = array.Length;

            while (startPointer < endPointer)
            {
                //Midpoint to check whether the required value id greater or lesser than it
                int midPointer = (startPointer + endPointer) / 2;

                //Check if the required value is greater than the midpoint
                if (array[midPointer] < targetValue)
                {
                    //Move the start point
                    startPointer = midPointer;
                }

                //Check if the required value is lesser than the midpoint
                else if (array[midPointer] > targetValue)
                {
                    //move the end point
                    endPointer = midPointer;
                }
                //check if the required value id equals to the midpoint
                else
                {
                    //when midPointer refers to the position of the value  
                    return midPointer;
                }
            }

            //return -1 if the value does not exist in the array
            return -1;
        }
    }


}

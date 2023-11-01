using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Search
{
    public class LinearSearch
    {
        //Declare an array
        private static int[] numberArray = { 1, 2, 3, 4, 6, 9, 22, 54, 43, 76, 87, 2, 4, 5, 6, 4, 7 };

        public LinearSearch()
        {
            Console.WriteLine(locateNumber(22));
        }

        
        //function to check whether the number exist in the array or not.
        private bool locateNumber(int number)
        {
            for(int x = 0; x < numberArray.Length; x++)
            {
                //check if the number exists in the array or not
                if (numberArray[x] == number)
                {
                    return true;
                }
            }

            //return false if the number does not exist in the array
            return false;
        }
    }
}

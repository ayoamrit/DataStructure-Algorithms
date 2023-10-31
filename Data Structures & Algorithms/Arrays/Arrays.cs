using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    internal class Arrays
    {
        static int length;

        public Arrays()
        {
            //Arrays contain anything: integers, floating point numbers, another array, objects, strings.
            //Arrays are fixed size; therefore they are not good for insertion and deletion
            //Array are good for GET, and SET if you know where the data is located
            int[] numberArray = fillArray();
            insertLast(numberArray, 9);
            printArray(numberArray);

            insertFirst(numberArray, 10);
            printArray(numberArray);

            insertAnywhere(numberArray, 11, 4);
            printArray(numberArray);
        }

        private int[] fillArray()
        {
            int[] numberArray = new int[10];
            for(int x = 0; x < 5; x++)
            {
                numberArray[x] = x + 1;
                length++;
            }

            return numberArray;
        }

        private void printArray(int[] array)
        {
            for(int x  = 0; x< array.Length; x++)
            {
                Console.WriteLine(array[x]);
            }
        }

        private void insertLast(int[] array, int number)
        {
            Console.WriteLine("Insert Last: ");
            array[length] = number; //Insert a new number at the end of the array
            length++;
        }

        private void insertFirst(int[] array, int number)
        {
            Console.WriteLine("Insert First: ");
            for (int x = length; x >=0; x--)
            {
                //Shift elements to the right
                array[x + 1] = array[x];
            }

            //insert a new number at the beginning of the array
            array[0] = number;
        }

        private void insertAnywhere(int[] array, int number, int position)
        {
            Console.WriteLine("Insert Anywhere: ");

            //Shift elements from the specified position to the end of the array
            //to make space for new number
            for (int x = length; x >= position; x--)
            {
                array[x + 1] = array[x];
            }

            //Insert the new number at the specified position
            array[position] = number;

            //Increment length
            length++;
        }
    }
}

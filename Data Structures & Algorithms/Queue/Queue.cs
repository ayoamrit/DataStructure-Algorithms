using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Queue
{
    public class Queue
    {

        private int maxSize { get; set; }  //sets the number of elements because this is an array
        private int[] queueArray { get; set; }  //actual array we will store elements in
        private int front { get; set; }  //index to keep track of front
        private int rear { get; set; } //index to keep track of rear


        public Queue(int maxSize)
        {
            //init 
            this.maxSize = maxSize;
            queueArray = new int[maxSize];
            front = 0;
            rear = -1;
        }

        //function to insert a new element in the queue
        public void enqueue(int number)
        {
            //Increment the pointer to store a new element in the array
            rear++;

            //Insert number in the array
            queueArray[rear] = number;
        }

        //function to remove,technically not, an element from the queue 
        public int dequeue()
        {
            //get the front most number in the queue
            int number = queueArray[front];

            //increment the variable to the next element
            front++;

            //return the removed number
            return number;
        }

        //function to show the front most number in the queue
        public int peek()
        {
            //return the front most number
            return queueArray[front];
        }
    }
}

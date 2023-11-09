using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stack
{
    public class Stack
    {

        //Stack is just like a pile of papers, & it follows last in first out.
        //Time complexity depends on how stack is being used.
        //Used with array: Time Complexity would be O(n), linear, because insertion and deletion in array in O(n)
        //Used with LinkedList: Time Complexity would be O(1), constant.

        
        private int maxSize { get; set; }  //max size is needed for the array stacks to init the size of the array
        private string[] stackArray { get; set; }
        private int top { get; set; }


        public Stack(int maxSize)
        {   
            this.maxSize = maxSize;  //holds constructor value

            this.stackArray = new string[maxSize];  //creates array with size

            this.top = -1;  //we give the top -1 because array is zero index; If we do not it will skip the first element
        }

        public void push(string value)
        {
            top++;
            stackArray[top] = value;
        }

        public string pop()
        {
            int oldTop = top;
            top--;
            return stackArray[oldTop];
        }

        public string peek()
        {
            return stackArray[top];
        }

        public bool isEmpty()
        {
            return top == -1;
        }

        public bool isFull()
        {
            return (top + 1) == maxSize ? true : false;
        }
    }
}

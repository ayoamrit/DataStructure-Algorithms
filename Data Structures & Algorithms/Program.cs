using DSA.Array;
using DSA.Search;
using DSA.LinkedList;
using DSA.Stack;
using DSA.Queue;

namespace DataStructure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //new Arrays();
            //new LinearSearch();

            //LinkedList
            LinkedLists linkedList = new LinkedLists();
            //linkedList.insertFirst(10);
            //linkedList.insertFirst(20);
            //linkedList.insertLast(50);
            //linkedList.insertFirst(30);

            //linkedList.removeFirst();
            //linkedList.removeLast();
            //linkedList.display();



            //Stack
            //Stack stack = new Stack(10);
            //stack.push("Lionel Messi");
            //stack.push("Christano Ronaldo");
            //stack.push("Luis Suarez");
            //stack.push("Gerrad Pique");
            //stack.push("Neymar Junior");

            //stack.pop();
            //Console.WriteLine(stack.peek());


            //Queue
            Queue queue = new Queue(10);
            queue.enqueue(1);
            queue.enqueue(2);
            queue.enqueue(3);
            queue.enqueue(4);
            queue.enqueue(5);

            queue.dequeue();
            Console.WriteLine(queue.peek());
        }

    }
}
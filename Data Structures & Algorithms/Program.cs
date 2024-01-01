using DSA.Array;
using DSA.Search;
using DSA.LinkedList;
using DSA.Stack;
using DSA.Queue;
using Data_Structures___Algorithms.BinarySearch;
using Data_Structures___Algorithms.BST;

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
            //Queue queue = new Queue(10);
            //queue.enqueue(1);
            //queue.enqueue(2);
            //queue.enqueue(3);
            //queue.enqueue(4);
            //queue.enqueue(5);

            //queue.dequeue();
            //Console.WriteLine(queue.peek());

            //Binary Search
            //BSearch binarySearch = new BSearch();


            //BinarySearchTree binarySearchTree = new BinarySearchTree();
            //binarySearchTree.Insert(1, "Amrit");
            //binarySearchTree.Insert(2, "Dhaliwal");
            //binarySearchTree.Insert(6, "Rajwinder");
            //binarySearchTree.Insert(10, "Cheema");
            //binarySearchTree.Insert(-1, "Banana");

            //Console.WriteLine(binarySearchTree.Locate(6));
            //Console.WriteLine(binarySearchTree.Exist(11));

            string number = "number";
            Console.WriteLine(number.IndexOf('b'));
            Console.WriteLine(number.Remove(0, number.IndexOf('b')));
        }

    }
}
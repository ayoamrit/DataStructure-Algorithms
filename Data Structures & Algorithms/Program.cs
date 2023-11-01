using DSA.Array;
using DSA.Search;
using DSA.LinkedList;

namespace DSA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //new Arrays();
            //new LinearSearch();

            //LinkedList
            LinkedLists linkedList = new LinkedLists();
            linkedList.insertFirst(10);
            linkedList.insertFirst(20);
            linkedList.insertLast(50);
            linkedList.insertFirst(30);

            linkedList.removeFirst();
            linkedList.display();

        }
    }
}
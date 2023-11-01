using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class LinkedLists
    {
        //represent head of the linked list
        public Node Head { get; set; }

        public LinkedLists()
        {
            //LinkedList = It is more like a train or people holding hands together. Moreover, the end of the linkedList is always null.
            //They consist of 'nodes'. Node is like a own bucket or container, or we can call it object, stored in the memory. 
            //They store data and a pointer that points, reference, to the next data. 
        }

        public void insertFirst(int data)
        {
            //Create a new node
            Node newNode = new Node();

            //put the data in the node
            newNode.data = data;
            //put the old node in the next
            newNode.next = Head;
            //Make the head new node
            Head = newNode;
        }

        public void removeFirst()
        {
            Node newNode = new Node();
            newNode = Head.next;
            Head = newNode;
        }

        public void insertLast(int data)
        {
            Node current = Head;
            while(current.next != null)
            {
                current = current.next;
            }

            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }

        public void display()
        {
            Node current = Head;
            while(current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
}

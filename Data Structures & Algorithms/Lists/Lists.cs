using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA .Lists
{
    internal class Lists
    {

        private static List<int> numbers = new List<int>();
        public Lists()
        {
            //List = data structure that represents a list of objects that can be access by index
            //       similar to arrays, but they dynamically increase/decrease in size.


            //Add elements in the list
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(7);
            numbers.Add(5);

            //Key functions of list

            //numbers.Remove(1);  => remove element from the list
            //numbers.Sort();     => sort list
            //numbers.IndexOf(1); => get index of specific element inside the list
            //numbers.Insert(10, 2);  => insert new element at a specific position in the list
            //numbers.Reverse(); => reverse the list
            //numbers.Clear();   => clear the list
            //numbers.Contains(1);  => check whether the list contain a specific element or not
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlists_algorithim
{
    public static class LinkedListExtensions
    {
        // James -- Nice use of an extensions method class with an extension Method.  though you don't really need 
        // the commit saying what this is doing like this.  I can see clearly what it is doing :)


        // James -- Also put this class in it's own file.  I feel like you are developing  bad habbits not organizing your code well.

        // Method to remove an object at a specified index. 
        public static bool RemoveAt<T>(this LinkedList<T> list, int index)
        {
            var FirstNode = 0;
            foreach (var node in list)
            {
                if (FirstNode == index)
                {
                    list.Remove(node);
                    return true;
                }
                FirstNode++;
            }
            return false;
        }

        //Inserts a new object at a specified index.returns false if index out of range.
        public static bool InsertAt<T>(this LinkedList<T> list, int index, T o)
        {
            var node = list.First;
            for (var StartingNode = 0; StartingNode < list.Count; StartingNode++)
            {

                if (StartingNode == index)
                {
                    list.AddAfter(node, o);
                    return true;
                }

                node = node.Next;
            }
            return false;
        }

        //method to print the elements of the list in reverse.
        public static void PrintReverse<T>(this LinkedList<T> list)
        {
            // create new array that is the size of the linked list (list.Count)
            // iterate over list and fill up array from the end
            // iterate over array printing out each element

            var StoreArray = list.Count;
            var EmptyArray = new T[list.Count];
            foreach (var word in list)
            {
                EmptyArray[StoreArray - 1] = word;
                StoreArray--;
            }

            foreach (var item in EmptyArray)
            {
                Console.WriteLine(item);
            }
        }

    }
}

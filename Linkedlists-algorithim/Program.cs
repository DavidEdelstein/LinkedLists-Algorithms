using System;
using System.Collections.Generic;

namespace Linkedlists_algorithim
{
    public static class LinkedListExtensions
    {
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
            for (var StartingNode = 0; StartingNode < list.Count ; StartingNode++)
            {

                if (StartingNode == index)
                {
                    list.AddAfter(node, o );
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
            var EmptyArray = new T [list.Count];
            foreach (var word in list)
            {
                EmptyArray[StoreArray-1]= word;
                StoreArray--;
            }

            foreach (var item in EmptyArray)
            {
                Console.WriteLine(item);
            }
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            //this is for part 1//methods to linked list data structure and design an algorithm.
            string[] words = { "the", "fox", "jumps", "over", "the", "dog" };
            LinkedList<string> sentence = new LinkedList<string>(words);

            //1.
            var shouldbetrue = sentence.RemoveAt(5);
            var shouldbefalse = sentence.RemoveAt(10);
            //2.
            sentence.InsertAt(3, "lazy");
            //3.
            sentence.PrintReverse();

          

            //this is for part 2// counts the occurences of numbers in an array.
            int[] numbers = new int[] { 1, 1, 1, 2, 4, 7, 7, 8, 9, 5 };
            int[] count = new int[10];

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < numbers.Length; y++)
                {
                    if (numbers[y] == x)
                    {
                        count[x]++;
                    }
                }
            }
            for (int x = 0; x < 10; x++)
            Console.WriteLine("Number " + x + " appears " + count[x] + " times");

            Console.ReadKey();
        }
    }
    
}

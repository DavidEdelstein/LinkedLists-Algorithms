using System;
using System.Collections.Generic;

namespace Linkedlists_algorithim
{
	
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

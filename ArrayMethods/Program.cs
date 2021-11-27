using System;

namespace ArrayMethods {
	class Program {
		static void Main(string[] args) {
			// COMMON ARRAY METHODS

			string[] words = { "This", "is", "the", "best", "language", "ever" };

			// Displaying an array
			// Console.WriteLine(words); <-- Does not work!!!

			Console.Write("Original array: ");

			for (int i = 0; i < words.Length; i++) {
				Console.Write($"{words[i]}, ");
			}


			// Reversing an array
			Array.Reverse(words);

			Console.Write("\nReversed array: ");

			for (int i = 0; i < words.Length; i++) {
				Console.Write($"{words[i]}, ");
			}


			// Sorting an array
			Array.Sort(words);

			Console.Write("\nSorted array: ");

			for (int i = 0; i < words.Length; i++) {
				Console.Write($"{words[i]}, ");
			}

			// Binary Search
			// Requires the array to be sorted.
			// Binary Search is an algorithm that optimizes lookups.
			int index = Array.BinarySearch(words, "language");
			Console.WriteLine($"\nItem \"language\" is in position {index}.");
		}
	}
}

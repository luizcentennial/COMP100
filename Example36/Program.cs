using System;

namespace Example36 {
	class Program {
		static void Main(string[] args) {
			/*
			 
			1. Create a method that returns an integer array with random numbers. The array size is expected as a parameter. 
			2. Create a method that displays an array in the console. The expected format is: [ a, b, c, d, e, ... ]
			
			*/

			// Creating a random array:
			int[] numbers = GetRandomIntegerArray(5);

			// Display numbers array in the console:
			//Console.WriteLine(numbers); // This does not show the array elements.

			// Instead, we need to call our own method:
			DisplayArray(numbers);
		}

		public static int[] GetRandomIntegerArray(int size) {
			Random randomizer = new Random();
			int[] array = new int[size];

			for (int i = 0; i < size; i++) {
				array[i] = randomizer.Next(10);
			}

			return array;
		}

		public static void DisplayArray(int[] array) {
			Console.Write("[ ");

			for (int i = 0; i < array.Length; i++) {
				if (i == array.Length - 1) {
					Console.Write(array[i]);
				}
				else {
					Console.Write($"{array[i]}, ");
				}
			}

			Console.Write(" ]");

			// The code below can replace all lines above.
			//Console.WriteLine($"[ {string.Join(", ", array)} ]");
		}
	}
}

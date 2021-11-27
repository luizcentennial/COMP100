using System;

namespace Exercise13 {
	class Program {
		static void Main(string[] args) {
			/*
			 
			 Write a console app that creates and displays an array
			 of integers of size 10, containing all numbers from
			 0 through 9.
			
			*/

			// Declaring and initializing an empty array.
			int[] numbers = new int[10];

			// Populating the array.
			for (int i = 0; i < numbers.Length; i++) {
				numbers[i] = i;
			}

			// Displaying the array.
			for (int i = 0; i < numbers.Length; i++) {
				Console.WriteLine($"{numbers[i]}");
			}
		}
	}
}

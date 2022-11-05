using System;

namespace Example24 {
	class Program {
		static void Main(string[] args) {
			// FOREACH LOOP:
			// Foreach loops offer a simplified syntax for for loops.

			// For example, let's say we need to display all elements of a given array.
			int[] numbers = { 10, 11, 12, 13, 14 };

			// The line below does not work.
			Console.WriteLine(numbers); // System.Int32[]

			// We need to iterate over the array elements, and display each one individually.
			for (int i = 0; i < numbers.Length; i++) {
				Console.Write($"{numbers[i]} ");
			}

			Console.WriteLine();

			// The solution above works, but there is another way.
			// We can use a foreach loop to achieve the same result.
			foreach (int element in numbers) { // For each number (integer) in the numbers array...
				// Do this:
				Console.Write($"{element} ");
			}

			Console.WriteLine();
		}
	}
}

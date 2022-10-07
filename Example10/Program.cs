using System;

namespace Example10 {
	class Program {
		static void Main(string[] args) {
			// IF STATEMENTS:
			// A conditional structure that determine whether a specified code block will run.

			Console.WriteLine("Line 9 runs.");

			if (true) { 
				// This code will run if condition = true.
				Console.WriteLine("Line 13 runs.");
			}

			Console.WriteLine("Line 16 runs.");

			if (3 > 5) { // false
				Console.WriteLine("Line 19 runs.");
			}
		}
	}
}

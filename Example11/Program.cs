using System;

namespace Example11 {
	class Program {
		static void Main(string[] args) {
			// IF-ELSE STATEMENTS:
			// A conditional structure that lets us define two conditions.
			bool condition = 0 < 1; // true

			if (condition) {
				// This block runs if condition = true.
				Console.WriteLine("Line 12 runs.");
			}
			else {
				// This block runs if condition = false.
				Console.WriteLine("Line 16 runs.");
			}
		}
	}
}

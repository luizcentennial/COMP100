using System;

namespace Example11 {
	class Program {
		static void Main(string[] args) {
			// IF-ELSE STATEMENTS:
			// A conditional structure that lets us define two conditions.
			bool condition = 0 > 1;

			if (condition) {
				// This block runs if condition = true.
				Console.WriteLine("Line 11 runs");
			}
			else {
				// This block runs if condition = false.
				Console.WriteLine("Line 15 runs.");
			}
		}
	}
}

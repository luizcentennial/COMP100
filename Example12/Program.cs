using System;

namespace Example12 {
	class Program {
		static void Main(string[] args) {
			// IF-ELSE IF-ELSE STATEMENTS:
			// A conditional structure that lets us define multiple conditions.
			bool condition = 0 > 1;
			bool anotherCondition = 3 > 5;

			if (condition) {
				// If condition = true, all subsequent blocks are ignored.
				// This block runs if condition = true.
				Console.WriteLine("Line 14 runs");
			}
			else if (condition || anotherCondition) { // Only checked if the previous condition (line 11) was false.
				// This block runs if (condition || anotherCondition) = true.
				Console.WriteLine("Line 18 runs.");
			}
			else { // Else blocks are always optional.
				// This is only checked if all previous conditions were false.
				Console.WriteLine("Line 22 runs.");
			}

			// Program continues from here...
		}
	}
}

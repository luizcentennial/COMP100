using System;

namespace Example23 {
	class Program {
		static void Main(string[] args) {
			// ARRAYS:
			// So far, our local variables have been capable of storing one single value at a time.
			string value = "Something";

			// Arrays allow for the storage of multiple values at the same time.
			// Arrays are strongly-typed data structures. In other words, all array elements have to be the same type.
			// Array sizes are usually fixed, that is, not expected to change.
			
			// There are many ways to work with arrays.

			// Declaration:
			string[] values;  // String array.
			int[] numbers; // Integer array.

			// Initialization:
			values = new string[5]; // Initializing to a new empty array with 5 empty slots.

			// With this approach, each slot has to be initialized individually, by index.
			values[0] = "Hello";
			values[1] = "World";
			values[2] = "!";

			// Each slot can be reassigned if needed.
			values[2] = "New value";

			// The method above is useful when array elements are unknown (e.g. user inputted).
			// However, sometimes all array elements are already known at compile time.
			// When that is the case, we can alternatively use a different initialization syntax.
			numbers = new int[] { 0, 1, 2, 3, 4 };

			// Arrays can be declared and initialized at the same time.
			char[] letters = new char[] { 'a', 'b', 'c' };

			// Alternatively, the following syntax can be used.
			double[] doubles = { 0.1, 0.2, 0.3, 0.4, 0.5 };
		}
	}
}

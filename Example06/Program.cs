using System;

namespace Example06 {
	class Program {
		static void Main(string[] args) {
			// NAMED CONSTANTS
			// Named constants are values that do not change over time.

			// When to use named constants?
			// Whenever a value is known at compile time, and said value cannot change.
			// Constants must be initialized upon declaration.
			// Constants are not user-provided.

			// For example:
			// Non-constant variables can have their values changed at any time.
			int number = 5; // camelCasing for non-constants.
			number = 6;
			number = 0;

			// However, constants cannot.
			const string Text = "I am a constant"; // PascalCasing is used to name constants.

			// The line below throws an error.
			//Text = "Hello";

			// BENEFITS:
			// 1. To apply restrictions to variables that must not change.
			// 2. Improved readability.
			// 3. Improved maintainability.
		}
	}
}

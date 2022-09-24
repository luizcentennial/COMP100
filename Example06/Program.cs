using System;

namespace Example06 {
	class Program {
		static void Main(string[] args) {
			// NAMED CONSTANTS
			// Named constants are values that do not change over time.

			// When to use named constants?
			// Whenever a value is known at compile time, and said value must not change.
			// Constants must be initialized upon declaration.
			// Constants are not usually user-provided.

			// BENEFITS:
			// 1. To apply restrictions to variables that must not change.
			// 2. Improved readability.
			// 3. Improved maintainability.

			// For example:
			// Non-constant variables can have their values changed at any time.
			int number = 5; // Non-constant local variables are camelCased.
			number = 6;
			number = 0;

			// However, constants cannot.
			const string Text = "I am a constant"; // Constants are PascalCased.

			// The line below throws an error.
			//text = "Hello";

			// C# has a few built-in constants:
			double pi = Math.PI;
		}
	}
}

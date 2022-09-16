using System;

namespace Example02 {
	class Program {
		static void Main(string[] args) {
			// DATA TYPES
			// Types of data.
			// The various types in which information can be "stored" as.

			// Variables can be declared, and in C# (strongly-typed language), a data type has to be assigned.
			// When intializing variables, the value's data type has to match that of the variable.

			// TEXT: string
			// Data type used for text.
			string text = "Hello, World!"; // Double quotes.

			// CHARACTERS: char
			// Data type used for single letters, numbers, symbols, or space.
			char character = 'a'; // Single quotes.

			// NUMBERS:
			// - Integers: int
			// Data type used for numbers without a decimal point.
			int number; // Declaration.
			number = 5; // Initialization.

			// - Floating-point numbers: double
			// Data type used for numbers with a decimal point.
			double floatingPointNumber = 3.14;

			// BOOLEANS: bool
			// Data type which value must be either true, or false.
			bool trueOrFalse = true;
		}
	}
}

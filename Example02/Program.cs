using System;

namespace Example02 {
	class Program {
		static void Main(string[] args) {
			// DATA TYPES:
			// Types of data.
			// The various types in which information can be "stored" as.

			// Variables can be declared to serve various purposes in your code.
			// In C# (strongly-types language), a variable has to be assigned a data type.
			// When initalizing variables, the value's data type has to match that of the variable.

			// TEXT: string
			// Data type used for text.
			string text; // Declaring a variable.
			text = "Hello, World!"; // Initializing (assigning) a variable.
									// strings use double-quotes.

			// CHARACTERS: char
			// Data type used for single letters, numbers, symbols, or space.
			char letter = 'a'; // Declaring and initializing a variable in one line.
							   // chars use single-quotes.

			// NUMBERS:
			// - Integers: int
			// Data type used for numbers without a decimal point.
			int number = 5;

			// - Floating-point numbers: double
			// Data type used for numbers with a decimal point.
			double floatingPointNumber = 3.14;

			// BOOLEANS: bool
			// Data type which value must be either true, or false.
			bool trueOrFalse = true; // or false;
		}
	}
}

using System;

namespace Example33 {
	class Program {
		static void Main(string[] args) {
			// OUT PARAMETERS:
			// The "out" keyword indicates that an object is passed into a method as a reference (or proxy), instead of a value.

			int input;

			// Passing "input" as reference into InitializeInt. This will change the object's original value.
			// Effectively, access to the "input" variable is passed into the method.
			// The "out" keyword does not require the object to be initialized in advance, because
			// usually, "out" parameters are expected to be initialized by the method.
			InitializeInt(out input);
			Console.WriteLine(input);   // Prints 1
		}

		// This method takes in an object as reference.
		public static void InitializeInt(out int number) {
			number = 1;
		}
	}
}

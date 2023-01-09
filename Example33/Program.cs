using System;

namespace Example33 {
	class Program {
		static void Main(string[] args) {
			// REF PARAMETERS:
			// The "ref" keyword indicates that an object is passed into a method as a reference (or proxy), instead of a value.

			int input = 5;

			// Passing "input" as value into AddOne. This does not change the object's original value.
			// Effectively, the number 5 is passed into the method, NOT the "input" variable.
			AddOne(input);				// Prints 6
			Console.WriteLine(input);   // Prints 5

			// Passing "input" as reference into Double. This will change the object's original value.
			// Effectively, access to the "input" variable is passed into the method.
			// The "ref" keyword requires the object to be initialized in advance.
			Double(ref input);			// Prints 10
			Console.WriteLine(input);   // Prints 10


			// IN PARAMETERS:
			// The "in" keyword indicates that an object is passed into a method as a reference, too. 
			// However, "in" parameters cannot be changed inside the calling method.
			TryToAddOne(in input);
		}

		// This method takes in an object as value.
		public static void AddOne(int number) {
			number = number + 1;

			Console.WriteLine(number);
		}

		// This method takes in an object as reference.
		public static void Double(ref int number) {
			number = number * 2;

			Console.WriteLine(number);
		}

		// This method takes in an object as reference, and tries to change it.
		public static void TryToAddOne(in int number) {
			// The line below throws an error. "In" parameters cannot be changed!
			//number = number * 2;

			Console.WriteLine(number);
		}
	}
}

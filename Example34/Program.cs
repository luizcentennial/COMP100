using System;

namespace Example34 {
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

			// For conciseness, local variables don't have to be declared in advance when they are
			// planned to be used by "out" parameters.
			InitializeInt(out int number);
			Console.WriteLine(number);

			// "Out" parameters can be used as a viable option when a method needs to initialize one, or multiple, variables,
			// or even when a method needs to "return" multiple values.
			CollectInputsFromUser(out string name, out int age);

			// From this point onwards, "name" and "age" are variables accessible to Main that can be used as needed.
		}

		// This method takes in an object as reference.
		public static void InitializeInt(out int number) {
			number = 1;
		}

		public static void CollectInputsFromUser(out string name, out int age) {
			Console.WriteLine("Please input your name: ");
			name = Console.ReadLine();

			Console.WriteLine("Please input your age: ");
			age = int.Parse(Console.ReadLine());
		}
	}
}

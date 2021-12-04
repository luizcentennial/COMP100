using System;

namespace Methods {
	class Program {
		static void Main(string[] args) {
			// METHODS

			// What are methods?

			// Methods are procedures that execute a sequence of steps (algorithm),
			// that have already been coded.
			// They encapsulate a piece of code, and are stored in your program.

			// One of the main goals is to keep your code organized.

			// Examples:
			// - The Main method.
			// - Console.WriteLine();
			// - "Some string".ToUpper();
			// - int[] numbers = { 1, 2, 3, 4, 5 };
			// - Array.Sort(numbers);

			// Invoking the Greet method:
			Greet();
			Greet("Clark Kent");

			// Invoking the Add method:
			int sum = Add(1, 2);
			Console.WriteLine($"The result is {sum}");

			double addition = Add(1.5, 3.14);
			Console.WriteLine($"The result is {addition:F3}");

			// Invoking the Multiply method:
			double multiplication = Multiply(1.71, 3.14);
			Console.WriteLine($"The result is {multiplication}");

			multiplication = Multiply(1.71);
			Console.WriteLine($"The result is {multiplication}");
		}

		// METHOD DECLARATIONS
		// There are many different ways to declare methods.
		// Methods will always have:
		// - A signature (header);
		// - A body.

		// Method signatures MUST have:
		// - An access modifier (i.e. public, private);
		// - A return type (i.e. string, int, void, etc);
		// - A name (usually is descriptive of what the method does).

		// Method signatures MAY have (dependent on use-case):
		// - The static keyword;
		// - Parameters.

		// All methods are declared inside classes.

		// Declaring a method that does not have a return value, and does not take in any parameters.
		public static void Greet() { // <-- Signature
			// Body
			Console.WriteLine("Greet method says hello!");
		}

		// Declaring a method that does not have a return value, and takes in parameters:
		// In C#, parameters are strongly typed.
		public static void Greet(string name) { // <-- Overloading Greet() method. Overloaded methods are methods with multiple definitions.
			Console.WriteLine($"Overloaded Greet method says hello, {name}!");
		}

		// Declaring a method that returns a value, and takes in parameters:
		public static int Add(int number1, int number2) { // <-- Parameters are comma-separated.
			int result = number1 + number2;

			// Methods that have a return value MUST return something.
			return result;
		}

		// Methods can return values of any type, and parameters can be of any type.
		public static double Add(double number1, double number2) {
			return number1 + number2;
		}

		// Declaring a method with optional parameters:
		public static double Multiply(double number1, double number2 = 1.0) {
			return number1 * number2;
		}
	}
}

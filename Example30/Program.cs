using System;

namespace Example30 {
	class Program {
		static void Main(string[] args) {
			// Passing both parameters:
			DisplayMultiplication(2.5, 5.3);

			// Passing only one parameter:
			DisplayMultiplication(2.5);
		}

		// Defining a method with optional parameters:
		public static void DisplayMultiplication(double first, double second = 1) { // Optional parameters have to be specified last.
			double result = first * second;

			Console.WriteLine($"The result is: {result}");
		}
	}
}

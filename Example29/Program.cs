using System;

namespace Example29 {
	class Program {
		static void Main(string[] args) {
			// Positional:
			DisplaySum(1, 1.5);

			// Named parameters:
			DisplaySum(second: 2.5, first: 5);
		}

		// Defining a method that takes in multiple parameters:
		public static void DisplaySum(int first, double second) {
			double result = first + second;

			Console.WriteLine($"The result is: {result}");
		}
	}
}

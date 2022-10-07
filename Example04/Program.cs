using System;

namespace Example04 {
	class Program {
		static void Main(string[] args) {
			// MATHEMATICAL OPERATIONS:
			double number = 5.1;
			double anotherNumber = 2.25;
			double total;

			// Addition:
			total = number + anotherNumber;

			// Subtraction:
			total = number - anotherNumber;

			// Multiplication:
			total = number * anotherNumber;

			// Division:
			total = number / anotherNumber;

			// Modulus:
			total = 15 % 4; // 3
			Console.WriteLine(total);

			// WARNING:
			// Data types can lead to incorrect results if not properly handled.
			double result = 15 / 4 * 3;
			Console.WriteLine(result);

			// The line above results in 9, but the correct result is 11.25.
			// The reason for this is because we are not paying enough attention to the data types.
			// An operation performed with two integers will always return an integer.
			// An operation performed with two doubles will always return a double.
			// An operation performed an integer and a double will always return a double.
			// To fix this problem, we have to convert at least one of the values to double.

			result = Convert.ToDouble(15) / 4 * 3;
			Console.WriteLine(result);
		}
	}
}

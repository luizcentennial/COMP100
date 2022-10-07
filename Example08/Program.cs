using System;

namespace Example08 {
	class Program {
		static void Main(string[] args) {
			// COMPARISON OPERATORS:
			// Perform comparisons between two values (operands).
			// Such comparisons can be called Boolean expressions, as they return true or false.

			// OPERATORS:
			// Less than: <
			// Less than or equal to: <=
			// Greater than: >
			// Greater than or equal to: >=
			// Equals: ==
			// Different (Not equal): !=

			// Example: 3 > 5 = False.
			// Example: 3 < 5 = True.

			// Verifying if 3 is less than 5.
			bool result = 3 < 5;
			Console.WriteLine(result);

			// Verifying if 3 is greater than 5.
			result = 3 > 5;
			Console.WriteLine(result);

			// Comparisons can be made between any data types.
			result = "true" == "True"; // False.
			Console.WriteLine(result);

			// We need to be careful when comparing strings.
			result = "TrUe".ToLower() == "tRuE".ToLower();
			Console.WriteLine(result);

			// We can also compare chars.
			result = 'a' != 'A';
			Console.WriteLine(result);
		}
	}
}

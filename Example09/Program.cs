using System;

namespace Example09 {
	class Program {
		static void Main(string[] args) {
			// COMPOUND BOOLEAN EXPRESSIONS:
			// We can use Boolean operators to combine two or more Boolean expressions.

			// OPERATORS:
			// And: &&
			// Or: ||
			// Not: !

			// Example: (3 < 5) && (1 > 0) = True.
			// Example: (3 > 5) || (1 > 0) = True.

			// Verifying if 3 is less than 5 and 1 is greater than 0.
			bool result = (3 < 5) && (1 > 0);
			Console.WriteLine(result);

			// Verifying if 3 is less than 5 and 1 is less than 0, or 3 is different than 5.
			result = 3 < 5 && 1 < 0 || 3 != 5;
			Console.WriteLine(result);

			// OPERATOR PRECEDENCE:
			// And (&&) operators are solved first.
			// Expressions are evaluated left to right.

			result = 3 < 5 && 1 < 0 || 3 != 5 && 0 == 0; // (3 < 5 && 1 < 0) || (3 != 5 && 0 == 0) = True.
			Console.WriteLine(result);
		}
	}
}

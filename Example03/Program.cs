using System;

namespace Example03 {
	class Program {
		static void Main(string[] args) {
			// CONVERTING BETWEEN DATA TYPES
			// At times, data will not immediately match the data type of the
			// variable you need to store it in.

			// For example, you may have an incoming string value, but an int type variable to store it.
			// When that happens, you need to convert the string value to int.

			// The line below throws an error.
			// That is because "a" is a string, and variable letter is a "char".
			//char letter = "a";

			// To fix the error, we need to convert from "string" to "char".
			char letter = Convert.ToChar("a"); // or...
			letter = char.Parse("a");

			// We can convert between any two data types.
			// The line below throws an error.
			//int number = "5";
			int number = Convert.ToInt32("5");
			number = int.Parse("5");

			// We can also convert from any data type to string.
			string text = Convert.ToString('a');

			// Sometimes, C# can IMPLICITLY convert between data types.
			// This happens when C# can convert from the uncoming type to the destination type
			// without ambiguity.
			double anotherNumber = 5; // 5 and 5.0 are the same number.

			// The line below cannot be implicitly converted. It throws an error.
			//int oneMoreNumber = 1.9;

			// The line below would be a perfectly good solution. 
			//int oneMoreNumber = Convert.ToInt32(1.9);

			// But, there is a more elegant solution:

			// CASTING
			// Casting is a data type conversion technique that can be used to convert
			// between any two data types THAT ARE NOT STRINGS.
			int oneMoreNumber = (int)1.99;

			// What value is effectively stored in the example above?
			Console.WriteLine(oneMoreNumber); // The original value gets truncated.

			// What if we use Convert.ToInt32 instead?
			Console.WriteLine(Convert.ToInt32(1.5)); // The original value is rounded to the nearest integer.

			// What if we use int.Parse?
			//Console.WriteLine(int.Parse(1.5)); // Parse methods expect a string, so this is not an option in this case.
		}
	}
}

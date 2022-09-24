using System;

namespace Example07 {
	class Program {
		static void Main(string[] args) {
			// STRING MANIPULATION
			// Dynamically generate strings, or somehow change a string to a modified version of it.

			// Dynamically generating strings:
			// String concatenation:
			string example1 = "The number Pi is " + Math.PI + ".";
			Console.WriteLine(example1);

			// String interpolation;
			string example2 = $"The number Pi is {Math.PI}.";
			Console.WriteLine(example2);

			// string.Format
			string example3 = string.Format("The number Pi is {0}, and today is {1}.", Math.PI, "Friday");
			Console.WriteLine(example3);


			// String formatters.
			// Reference: https://gist.github.com/luizcentennial/c6353c2ae21815420e616a6db3897b4c
			string example4 = $"The number Pi is {Math.PI:F}.";
			Console.WriteLine(example4);


			// Getting Substrings:
			string example5 = "C# is a great language.";
			Console.WriteLine(example5.Substring(6)); // Returns a substring starting at character index 6 (a).
			Console.WriteLine(example5.Substring(6, 7)); // Returns a 7-characters substring starting at index 6.


			// Changing casing patterns:
			string example6 = "C# is a great language.";
			Console.WriteLine(example6.ToUpper());
			Console.WriteLine(example6.ToLower());


			// Checking if string contains:
			string example7 = "C# is a GREAT language.";
			Console.WriteLine(example7.Contains('a')); // returns true
			Console.WriteLine(example7.Contains("best")); // returns false
			Console.WriteLine(example7.ToLower().Contains("great")); // returns true
		}
	}
}

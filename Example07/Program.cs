using System;

namespace Example07 {
	class Program {
		static void Main(string[] args) {
			// STRING MANIPULATION

			// Dynamically generating strings:
			// String concatenation:
			string example1 = "The number Pi is " + Math.PI + ".";

			// String interpolation
			string example2 = $"The number Pi is {Math.PI}.";

			// string.Format
			string example3 = string.Format("The number Pi is {0}, and today is {1}. ", Math.PI, "Monday");

			Console.WriteLine(example1);
			Console.WriteLine(example2);
			Console.WriteLine(example3);

			// String formatters
			string example4 = $"The number Pi is {Math.PI:F}.";
			Console.WriteLine(example4);


			// Getting Substrings:
			string example5 = "The quick brown fox.";
			Console.WriteLine(example5.Substring(5)); // Substring calls with one single parameter
													  // will return a substring from character index 5 (u).

			Console.WriteLine(example5.Substring(5, 4)); // Substring calls with two parameters will
														 // return a substring of X characters, starting from
														 // character index 5 (u).

			// Changing casing patterns:
			string example6 = "C# is a great language.";
			Console.WriteLine(example6.ToUpper());
			Console.WriteLine(example6.ToLower());

			// Checking if string contains:
			string example7 = "C# is the BEST language.";
			Console.WriteLine(example7.Contains('x')); // Check if example7 contains an 'x' character.
			Console.WriteLine(example7.ToLower().Contains("best")); // Check if example7 contains the word "best".
																	// ToLower or ToUpper can be used to make sure
																	// your code is not case-sensitive.
		}
	}
}

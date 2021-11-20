using System;

namespace Continue {
	class Program {
		static void Main(string[] args) {
			// CONTINUE KEYWORD
			// The continue keyword is used to "force" the loop
			// to stop THE CURRENT ITERATION, and immediately
			// start the next one.

			// The continue keyword is often used in if statements
			// to control code execution.

			// Example: Write a console app that prints all numbers from 0 to 20,
			// except multiples of 5.

			for (int i = 0; i < 21; i++) {
				if (i % 5 == 0) {
					continue;
				}

				Console.WriteLine(i);
			}
		}
	}
}

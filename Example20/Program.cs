using System;

namespace Example20 {
	class Program {
		static void Main(string[] args) {
			// BREAK:
			// The "break" keyword is used to break out of a loop,
			// completely interrupting its execution.

			Console.WriteLine("Program starts.");
			int counter = 0;

			while (true) {
				Console.WriteLine(counter);
				counter++;

				// If the condition below returns true, the loop will be immediately interrupted.
				if (counter == 5) {
					break;

					// In this case, nothing is executed past the "break" keyword.
					// The loop completely stops.
				}
			}

			// And the code continues from here.
			Console.WriteLine("Program ends.");
		}
	}
}

using System;

namespace Example21 {
	class Program {
		static void Main(string[] args) {
			// CONTINUE:
			// The "continue" keyword forces a loop to immediately interrupt the current iteration,
			// and start the next one (if any).

			Console.WriteLine("Program starts.");
			int counter = 0;

			while (counter < 10) {
				counter++;

				// If the condition below returns true, this iteration will be immediately interrupted.
				if (counter == 5) {
					continue;

					// In this case, nothing past the "continue" keyword is executed.
					// The next iteration starts immediately (counter = 6).
				}

				Console.WriteLine(counter);
			}

			// And the code continues from here.
			Console.WriteLine("Program ends.");
			// ...
		}
	}
}

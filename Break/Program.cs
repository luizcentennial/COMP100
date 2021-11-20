using System;

namespace Break {
	class Program {
		static void Main(string[] args) {
			// BREAK KEYWORD
			// The break keyword can be used inside loops to stop the loop execution.

			// We can put the break inside an if statement, for example,
			// and stop the loop if a specified condition is met.

			while (true) {
				Console.WriteLine("Loop is looping...");

				// Adding the break keyword here makes the loop run only once.
				// If the line below is commented out, the loop runs forever.
				break;
			}

			Console.WriteLine("Loop ended.");
		}
	}
}

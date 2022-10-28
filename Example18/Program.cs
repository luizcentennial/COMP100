using System;

namespace Example18 {
	class Program {
		static void Main(string[] args) {
			// FOR LOOPS:
			// For loops are pre-processed loops.
			// That is, it checks the condition before even running the first time.
			// Depending on the condition, the loop may not run at all - though this is not typically observed in for loops.

			// For loops incorporate three main arguments:
			// - Control variable;
			// - Condition;
			// - Increment.

			// In for loops, the control variable is usually "built-in" the syntax.

			for (int counter = 0; counter < 10; counter++) { // counter++ equals counter = counter + 1.
				// Repeat this code while the condition above = true.
				Console.WriteLine(counter);
			}
		}
	}
}

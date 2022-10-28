using System;

namespace Example17 {
	class Program {
		static void Main(string[] args) {
			// WHILE LOOP:
			// While loops are pre-processed loops.
			// That is, it checks the condition before even running the first time.
			// Depending on the condition, the loop may never run at all.

			// A control variable is still needed:
			int counter = 0;

			while (counter < 10) { // If condition = true...
				// Repeat this code..
				Console.WriteLine(counter);
				counter = counter + 1; // Increment by 1.
			} 
		}
	}
}

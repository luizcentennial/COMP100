using System;

namespace Example16 {
	class Program {
		static void Main(string[] args) {
			// LOOPING STRUCTURES:
			// Are structures that repeat a piece of code a number of times.

			// Sometimes, we need to execute a code block multiple times.
			// For example, if we had to display all numbers from 0 to 9 on the screen,
			// the following code would work:
			Console.WriteLine(0);
			Console.WriteLine(1);
			Console.WriteLine(2);
			Console.WriteLine(3);
			Console.WriteLine(4);
			Console.WriteLine(5);
			Console.WriteLine(6);
			Console.WriteLine(7);
			Console.WriteLine(8);
			Console.WriteLine(9);
			Console.WriteLine();

			// However, it is not efficient (obviously).
			// If we had to display all numbers from 0 to 10,000, it would take a long while.

			// The better way is to use loops!

			// DO-WHILE LOOP:
			// Do-while loops are post-processed loops.
			// That is, it runs the first time, before checking if its condition is true.
			// All do-while loops run at least once.

			// When working with loops, a control variable is needed.
			// A control variable will assist in "controling" the loop, ensuring it runs
			// exactly the intended number of times.
			int counter = 0;

			do {
				// Repeat this code...
				Console.WriteLine(counter);
				counter = counter + 1; // Increment by 1.
			} while (counter < 10); // While condition = true.
		}
	}
}

using System;

namespace Example25 {
	class Program {
		static void Main(string[] args) {
			// NESTED LOOPS:
			// It is possible to put loops inside loops.

			for (int row = 0; row < 5; row++) { // Prints rows.
				for (int column = 0; column < 5; column++) { // Prints columns.
					Console.Write($"{row}{column} ");
				}

				Console.WriteLine(); // Line break.
			}
		}
	}
}

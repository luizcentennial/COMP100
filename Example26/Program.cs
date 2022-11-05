using System;

namespace Example26 {
	class Program {
		static void Main(string[] args) {
			// PATTERNS:
			// We can use nested loops to draw patterns in the console.

			for (int row = 0; row < 10; row++) { // Prints rows.
				for (int column = 0; column < 10; column++) { // Prints columns.
					if (row == column || row + column == 9) {
						Console.Write("XX ");
					}
					else {
						Console.Write("   ");
					}
				}

				Console.WriteLine(); // Line break.
			}
		}
	}
}

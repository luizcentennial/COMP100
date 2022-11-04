using System;

namespace Example26 {
	class Program {
		static void Main(string[] args) {
			// PATTERNS:
			// We can use nested loops to draw patterns in the console.

			for (int row = 0; row < 10; row++) {
				for (int column = 0; column < 10; column++) {
					if (row == column) {
						Console.Write("XX ");
					}
					else if ( row + column == 9) {
						Console.Write("XX ");
					}
					else {
						//Console.Write($"{row}{column} ");
						Console.Write($"   ");
					}
				}

				Console.WriteLine();
			}
		}
	}
}

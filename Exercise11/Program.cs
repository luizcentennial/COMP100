using System;

namespace Exercise11 {
	class Program {
		static void Main(string[] args) {
			// Write a console app that prints the following 10x10 pattern.

			// XXXXXXXXXXXXXXXXXXX 
			// X X             X X 
			// X   X         X   X 
			// X     X     X     X 
			// X       X X       X 
			// X       X X       X 
			// X     X     X     X  
			// X   X         X   X  
			// X X             X X  
			// XXXXXXXXXXXXXXXXXXX   

			for (int row = 0; row < 10; row++) {
				for (int column = 0; column < 10; column++) {
					if (row == 0 || row == 9) {
						if (column == 9) {
							Console.Write("X");
						}
						else {
							Console.Write("XX");
						}
					}
					else if (row + column == 9 || row == column || column == 0 || column == 9) {
						Console.Write("X ");
					}
					else {
						Console.Write("  ");
					}
				}

				Console.WriteLine();
			}
		}
	}
}

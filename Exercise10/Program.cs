using System;

namespace Exercise10 {
	class Program {
		static void Main(string[] args) {
			// Write a console app that prints the following 10x10 pattern.

			// * * * * * * * * * 0 
			// * * * * * * * * 0 * 
			// * * * * * * * 0 * * 
			// * * * * * * 0 * * * 
			// * * * * * 0 * * * * 
			// * * * * 0 * * * * * 
			// * * * 0 * * * * * * 
			// * * 0 * * * * * * * 
			// * 0 * * * * * * * * 
			// 0 * * * * * * * * * 

			for (int row = 0; row < 10; row++) {
				for (int column = 0; column < 10; column++) {
					if (row + column == 9) {
						Console.Write("0 ");
					}
					else {
						Console.Write("* ");
					}
				}

				Console.WriteLine();
			}
		}
	}
}

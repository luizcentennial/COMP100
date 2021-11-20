using System;

namespace Exercise12 {
	class Program {
		static void Main(string[] args) {
			/*
			 
			Write a console app that prints the following pattern. The application should prompt the user for the number of rows and columns.
			Clear the console before printing the pattern.
			 
			*/

			Console.WriteLine("Please input the number of rows: ");
			int rows = int.Parse(Console.ReadLine());

			Console.WriteLine("Please input the number of columns: ");
			int columns = int.Parse(Console.ReadLine());

			Console.Clear();

			for (int row = 0; row < rows; row++) {
				for (int column = 0; column < columns; column++) {
					if ((column - row) % 8 == 0 || (column + row) % 8 == 0) {
						Console.Write(" ");
					}
					else {
						Console.Write("X");
					}
				}

				Console.WriteLine();
			}
		}
	}
}

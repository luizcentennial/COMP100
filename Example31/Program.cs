using System;

namespace Example31 {
	class Program {
		static void Main(string[] args) {
			double division = Divide(2, 3.5);

			Console.WriteLine(division);
		}

		// Defining a method that returns an object:
		public static double Divide(double first, double second) {
			double result = first / second;

			return result;
		}
	}
}

using System;

namespace Example35 {
	class Program {
		static void Main(string[] args) {
			// PARAMS KEYWORD:
			// The keyword "params" can be used as a modifier to method parameters.
			// It makes it more convenient to invoke methods that take in multiple values.
			// And it can be used an alternative to defining array arguments.

			// Method CalculateAverage requires an array object as a parameter.
			double[] array = { 0.5, 1.2, 3, 4, 5 };
			double average = CalculateAverage(array);

			Console.WriteLine($"The average with array is: {average}");

			// Method CalculateAverageWithParams do not require an array object.
			average = CalculateAverageWithParams(0.5, 1.2, 3, 4, 5);

			Console.WriteLine($"The average with params is: {average}");
		}

		public static double CalculateAverage(double[] numbers) {
			double sum = 0;

			foreach (double number in numbers) {
				sum += number;
			}

			return sum / numbers.Length;
		}

		public static double CalculateAverageWithParams(params double[] numbers) {
			double sum = 0;

			foreach (double number in numbers) {
				sum += number;
			}

			return sum / numbers.Length;
		}
	}
}

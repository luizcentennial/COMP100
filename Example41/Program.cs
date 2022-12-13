using System;

namespace Example41 {
	class Program {
		/*
		 
		 FIBONACCI

		 Write a program that prints the first N elements
		 in the Fibonacci series. N is a user-specified number.
		 
		*/

		static void Main(string[] args) {
			Console.WriteLine("Please enter the number of elements to display: ");
			int input = int.Parse(Console.ReadLine());

			int[] fibonacci = GetFibonacciArray(input);

			DisplayArray(fibonacci);
		}

		public static int[] GetFibonacciArray(int numberOfElements) {
			int[] series = new int[numberOfElements];

			for (int i = 0; i < numberOfElements; i++) {
				if (i < 2) {
					series[i] = i;
				}
				else {
					series[i] = series[i - 1] + series[i - 2];
				}
			}

			return series;
		}

		public static void DisplayArray(int[] array) {
			DisplayMessage($"[ {string.Join(", ", array)} ]", ConsoleColor.Yellow);
		}

		public static void DisplayMessage(string message, ConsoleColor color) {
			Console.ForegroundColor = color;

			Console.WriteLine(message);

			Console.ResetColor();
		}
	}
}

using System;

namespace Example39 {
	class Program {
		/*
		 
		PRIME NUMBERS

		Write a console app that identifies prime numbers.

		Users should be able to input a number, and the app would,
		in turn, respond if that is a prime number.
		
		*/

		static void Main(string[] args) {
			while (true) {
				Console.Clear();
				Console.WriteLine("Please enter a number: ");
				int input = int.Parse(Console.ReadLine());

				bool isPrimeNumber = IsPrime(input);

				if (isPrimeNumber) {
					DisplayMessage($"{input} is a prime number.", ConsoleColor.Green);
				}
				else {
					DisplayMessage($"{input} is not a prime number.", ConsoleColor.Red);
				}

				Console.WriteLine("\nPick another? (Y/N)");
				string pickAnother = Console.ReadLine();

				if (pickAnother.ToUpper() != "Y") {
					break;
				}
			}
		}

		public static bool IsPrime(int number) {
			int denominator = 2;
			bool isPrime = true;

			while (denominator < number) {
				if (number % denominator == 0) {
					isPrime = false;
					break;
				}

				denominator++;
			}

			return isPrime;
		}

		public static void DisplayMessage(string message, ConsoleColor color) {
			Console.ForegroundColor = color;
			
			Console.WriteLine(message);

			Console.ResetColor();
		}
	}
}

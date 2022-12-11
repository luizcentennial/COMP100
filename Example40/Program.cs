using System;

namespace Example40 {
	class Program {
		/*
		 
		FACTORIAL
		
		Write a program that calculates the factorial of a 
		number provided by the user.
		 
		*/

		static void Main(string[] args) {
			Console.WriteLine("Please enter a number: ");
			int number = int.Parse(Console.ReadLine());

			int factorial = GetFactorial(number);

			DisplayMessage($"{number}! = {factorial}.", ConsoleColor.Cyan);
		}

		public static int GetFactorial(int number) {
			if (number == 0)
				return 1;
			else
				return number * GetFactorial(number - 1);
		}

		public static void DisplayMessage(string message, ConsoleColor color) {
			Console.ForegroundColor = color;
			
			Console.WriteLine(message);

			Console.ResetColor();
		}
	}
}

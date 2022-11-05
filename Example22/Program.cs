using System;

namespace Example22 {
	class Program {
		static void Main(string[] args) {
			/*
			 
			Write a console app that asks the user to input their name.
			After collecting the input, display a friendly greeting message,
			and ask the user if they want to input their name again.

			If the answer is Y (yes), restart the application.
			If the answer is N (no), exit the application.
			If the answer is anything other than Y or N, display an error message.

			The application should be able to run indefinitely, as many times as the user wants.
			 
			*/

			while (true) {
				Console.WriteLine("Please input your name: ");
				string name = Console.ReadLine();

				Console.WriteLine($"Hello, {name}!");

				Console.WriteLine("Would you like to input your name again? (Y/N)");
				string input = Console.ReadLine();

				if (input.ToUpper() == "Y") {
					Console.Clear();

					continue;
				}
				else if (input.ToUpper() == "N") {
					break;
				}
				else {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine($"\nERROR: '{input}' is not an expected input. Please try again.\n");
					Console.ResetColor();
				}
			}
		}
	}
}

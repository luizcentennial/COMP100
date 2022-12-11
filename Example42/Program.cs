using System;

namespace Example42 {
	class Program {
		/*
		 
		ODDS AND EVENS

		Odds and evens is a simple game of chance and hand game, 
		involving two players. One selects "odds", while the other
		is "evens". They will simultaneously reveal a number of 
		fingers, and will win or lose depending on whether the total
		number of fingers revealed is odd or even. 
		
		The game may be used to make a decision or played for fun. The 
		finger game is also known as swords, choosies, pick, odds-on poke, 
		or bucking up. 

		In this exercise, you will write an Odds and Evens game, where
		a user will play with the computer.

		The program should prompt the player to select between odds and evens,
		and then input an integer.

		The computer will select a random integer between 0 and 5.

		The player wins if:

		1. They selected "oods", and the sum of both selected numbers is an odd number.
		2. They selected "evens", and the sum of both selected numbers is an even number.
		 
		*/
		static void Main(string[] args) {
			while (true) {
				Console.Clear();

				bool playerWins = false;
				int userNumber;
				int cpuNumber;

				while (true) {
					int selection = DisplayOptions();

					if (selection == 1) {
						userNumber = SelectNumber();
						cpuNumber = SelectNumber(true);
						playerWins = (userNumber + cpuNumber) % 2 != 0;

						break;
					}
					else if (selection == 2) {
						userNumber = SelectNumber();
						cpuNumber = SelectNumber(true);
						playerWins = (userNumber + cpuNumber) % 2 == 0;

						break;
					}
					else {
						DisplayMessage("Invalid selection. Please try again. \n", ConsoleColor.Red);

						continue;
					}
				}

				DisplayMessage($"\nPlayer: {userNumber} \n" +
							   $"CPU: {cpuNumber}");

				if (playerWins) {
					DisplayMessage("Player wins!", ConsoleColor.Green);
				}
				else {
					DisplayMessage("CPU wins!", ConsoleColor.Red);
				}

				Console.WriteLine("\nPlay again? (Y/N)");
				string playAgain = Console.ReadLine();

				if (playAgain.ToUpper() != "Y") {
					break;
				}
			}
		}

		public static int DisplayOptions() {
			Console.WriteLine("Please select between odds or evens: \n" +
							  "1. Odds \n" +
							  "2. Evens");

			int selection = int.Parse(Console.ReadLine());

			return selection;
		}

		public static int SelectNumber(bool isCPU = false) {
			int selection;

			if (isCPU) {
				selection = new Random().Next(0, 6);
			}
			else {
				Console.WriteLine("Please input an integer: ");
				selection = int.Parse(Console.ReadLine());
			}

			return selection;
		}

		public static void DisplayMessage(string message, ConsoleColor color = ConsoleColor.White) {
			Console.ForegroundColor = color;

			Console.WriteLine(message);

			Console.ResetColor();
		}
	}
}

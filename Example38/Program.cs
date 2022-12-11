using System;

namespace Example38 {
	class Program {
		/*
		 
		ATM SIMULATOR

		Write a console application that simulates an ATM machine.

		When loading the application, users must be presented with a menu that
		displays the following options:

		1. Deposit;
		2. Withdraw.

		The starting balance should be zero. From there, users should be able to
		perform deposits or withdrawals, based on menu selections.

		Once an option is selected, it should prompt the user to input the amount,
		and then add or subtract that amount from the account balance accordingly.

		*/

		static double balance = 0;

		static void Main(string[] args) {
			while (true) {
				Console.Clear();

				double amount;
				bool success;

				while (true) {
					int input = DisplayMenu();

					if (input == 1) {
						amount = GetTransactionAmount();
						success = Deposit(amount);

						break;
					}
					else if (input == 2) {
						amount = GetTransactionAmount();
						success = Withdraw(amount);

						break;
					}
					else {
						success = false;
						DisplayMessage("Invalid selection. Please try again.", true);
					}
				}

				if (success) {
					DisplayMessage("Transaction successfully processed.");
				}
				else {
					DisplayMessage("Error processing transaction.", true);
				}

				Console.WriteLine($"Account balance: {balance:C}\n");

				Console.WriteLine("Would you like to do another transaction? (Y/N)");
				string tryAgain = Console.ReadLine();

				if (tryAgain.ToUpper() == "Y") {
					continue;
				}
				else if (tryAgain.ToUpper() == "N") {
					break;
				}
				else {
					DisplayMessage("Invalid selection.", true);
				}
			}
		}

		public static int DisplayMenu() {
			Console.WriteLine("==============================================");
			Console.WriteLine("||              ATM SIMULATOR               ||");
			Console.WriteLine("==============================================");
			Console.WriteLine("\nPlease select an option: ");
			Console.WriteLine("1. Deposit");
			Console.WriteLine("2. Withdraw");

			int selection = int.Parse(Console.ReadLine());

			return selection;
		}

		public static double GetTransactionAmount() {
			Console.WriteLine("Please input the transaction amount: ");
			double amount = double.Parse(Console.ReadLine());

			return amount;
		}

		public static bool Deposit(double amount) {
			if (amount < 0) {
				DisplayMessage("Deposit amount cannot be negative.", true);

				return false;
			}

			balance += amount;

			return true;
		}

		public static bool Withdraw(double amount) {
			if (amount < 0) {
				DisplayMessage("Withdrawal amount cannot be negative.", true);

				return false;
			}

			if (balance >= amount) {
				balance -= amount;

				return true;
			}

			return false;
		}

		public static void DisplayMessage(string message, bool isError = false) {
			if (isError) {
				Console.ForegroundColor = ConsoleColor.Red;
			}
			else {
				Console.ForegroundColor = ConsoleColor.Green;
			}

			Console.WriteLine($"{message}\n");
			Console.ResetColor();
		}
	}
}

using System;

namespace Calculator {
	class Program {
		/*

		In this exercise, we are implementing a calculator console app. 

		When the application starts, a menu is displayed to the user, containing
		four options:

		1) Addition
		2) Subtraction
		3) Multiplication
		4) Division

		The user is, then, prompted to select from the presented numeric options.

		Upon user selection, the application should proceed with the desired calculation.
		For that, the user should be prompted again to input two operands. 
		Once all inputs are successfully collected, the result is displayed to the user.

		After displaying the result, the user should be asked if another operation is desired.
		If so, the main menu should be presented again, from which point, the process restarts from
		the beginning. Else, the application should end.

		Write the methods below to implement the required functionalities. Use your Main method
		to call the methods below appropriately.

		1. 	Implement a method called DisplayMenu.
			This method does not take in any parameters, nor does it return a value.
			It displays a menu in the console that reflects the functionality described above.
			Note that this method does not implement any mathematical operations. It is 
			intended, exclusively, for displaying the calculator menu, as well as collecting
			menu selection inputs.

		2.	Implement a method called Addition.
			This method takes in two numeric parameters, and returns a numeric value that represents
			the addition of the two provided numbers, in the appropriate data type.
			Once completed, update your DisplayMenu method to ensure Addition is called when the
			proper selection is made.
			
		3.	Implement a method called Subtraction.
			This method takes in two numeric parameters, and returns a numeric value that represents
			the subtraction of the two provided numbers, in the appropriate data type.
			Once completed, update your DisplayMenu method to ensure Subtraction is called when the
			proper selection is made.

		4.	Implement a method called Multiplication.
			This method takes in two numeric parameters, and returns a numeric value that represents
			the multiplication of the two provided numbers, in the appropriate data type.
			Once completed, update your DisplayMenu method to ensure Multiplication is called when the
			proper selection is made.
	
		5.	Implement a method called Division.
			This method takes in two numeric parameters, and returns a numeric value that represents
			the division of the two provided numbers, in the appropriate data type.
			Once completed, update your DisplayMenu method to ensure Division is called when the
			proper selection is made.

		*/

		static void Main(string[] args) {
			while (true) {
				DisplayMenu();

				Console.WriteLine("\nStart over? (Y/N)");
				string input = Console.ReadLine();

				if (input.ToUpper() == "N") { // I want to cover both n and N.
					break;
				}

				Console.Clear();
			}			
		}

		public static void DisplayMenu() {
			string input;
			double number1;
			double number2;
			double result;

			Console.WriteLine(	"Please select an option: \n");
			Console.WriteLine(	"1) Addition \n" +
								"2) Subtraction \n" +
								"3) Multiplication \n" +
								"4) Division \n");

			input = Console.ReadLine();

			Console.WriteLine("\nPlease input the first number: ");
			number1 = double.Parse(Console.ReadLine());

			Console.WriteLine("\nPlease input the second number: ");
			number2 = double.Parse(Console.ReadLine());

			switch (input) {
				case "1":
					result = Addition(number1, number2);

					break;
				case "2":
					result = Subtraction(number1, number2);

					break;
				case "3":
					result = Multiplication(number1, number2);

					break;
				case "4":
					result = Division(number1, number2);

					break;
				default:
					return;
			}

			Console.WriteLine($"\nThe result is {result}");
		}

		public static double Addition(double number1, double number2) {
			return number1 + number2;
		}

		public static double Subtraction(double number1, double number2) {
			return number1 - number2;
		}

		public static double Multiplication(double number1, double number2) {
			return number1 * number2;
		}

		public static double Division(double number1, double number2) {
			if (number2 == 0) {
				Console.BackgroundColor = ConsoleColor.Red;

				throw new Exception("FATAL ERROR: Cannot divide by zero.");
			}

			return number1 / number2;
		}
	}
}

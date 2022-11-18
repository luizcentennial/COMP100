using System;

namespace Example28 {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Please input your name: ");
			string input = Console.ReadLine();

			Greet(input);
		}

		// Defining a method that takes in parameters:
		public static void Greet(string name) {
			Console.WriteLine($"Hello, {name}!");
		}
	}
}

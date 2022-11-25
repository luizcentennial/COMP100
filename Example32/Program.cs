using System;

namespace Example32 {
	class Program {
		static void Main(string[] args) {
			// METHOD OVERLOADING:
			// Method overloading is a technique that allows developers to define multiple definitions for a method.
			// For example, method Console.WriteLine has many definitions in the Console class.

			Greet();
			Greet("Luiz");
			Greet("Luiz", "Parente");
		}

		public static void Greet() {
			Console.WriteLine("Hello!");
		}

		public static void Greet(string firstName) {
			Console.WriteLine($"Hello, {firstName}!");
		}

		public static void Greet(string firstName, string lastName) {
			Console.WriteLine($"Hello, {firstName} {lastName}!");
		}
	}
}

using System;

namespace Example19 {
	class Program {
		static void Main(string[] args) {
			// INFINITE LOOPS:
			// An infinite loop is a loop that "never" stops.

			// Infinite while:
			while (true) {
				Console.WriteLine("Loop is running...");
			}

			// Infinite do-while:
			do {
				Console.WriteLine("Loop is running...");
			} while (true);

			// Infinite for:
			for (; ; ) {
				Console.WriteLine("Loop is running...");
			}
		}
	}
}

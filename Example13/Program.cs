using System;

namespace Example13 {
	class Program {
		static void Main(string[] args) {
			// SWITCH STATEMENTS:
			// A conditional structure that lets us define code blocks for multiple scenarios.

			int variable = 1;

			switch (variable) {
				// Each "case" is a possible value for "variable".
				case 1:
					Console.WriteLine("Value is 1.");
					break;
				case 2:
					Console.WriteLine("Value is 2.");
					break;
				case 3:
					Console.WriteLine("Value is 3.");
					break;
				default:
					// Default blocks are optional.
					Console.WriteLine("Value is unknown.");
					break;
			}
		}
	}
}

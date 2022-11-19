using System;

namespace Example27 {
	class Program {
		static void Main(string[] args) {
			// METHODS:
			// Methods are structures that encapsulate logic.
			// Methods != Functions.
			// Methods depend on a class to exist. They exist inside classes.
			// Functions exist on its own. They do not depend on classes to exist.

			// Main advantages of methods:
			// - Code organization: For example, the Console class has many methods for console manipulation.
			// - Code becomes more DRY (Don't Repeat Yourself).

			// Once methods are defined, they can be called:
			Greet();

			// Important notes:
			// - In COMP100, ALL methods are public.
			// - In COMP100, ALL methods are static.
			// - However, some methods are not static, and some methods are not public.
		}

		// Methods are defined here - INSIDE the class, but OUTSIDE other methods.
		// <access modifier> static <return type> MethodName(<parameters, which are optional>) { <Method logic> }
		public static void Greet() {
			// Method logic goes here.
			Console.WriteLine("Hello!");
		}
	}
}

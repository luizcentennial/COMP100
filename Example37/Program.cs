using System;

namespace Example37 {
	class Program {
		// SCOPES:
		// A scope is a region in which an object exists.
		// The scope of a local variable is the region in which it is declared.
		// However, objects declared in parent scopes are accessible inside child scopes,
		// even though the opposite is NOT true.

		// It is possible to define variables at the class level.
		// These variables will be accessible across all of this class' methods.
		// In C#, these variables are called "fields".
		static string classVariable;

		static void Main(string[] args) {
			// For example, a local variable created in Main, is only accessible inside Main.
			string variable = "I am local to Main.";

			// The line below throws an error, as "anotherVariable" is not an object Main knows of.
			//Console.WriteLine(anotherVariable);

			classVariable = "I can be accessed there";
		}

		public static void AnotherMethod() {
			// AnotherMethod's scope starts here =================

			// A local variable declared inside AnotherMethod is not accessible in Main.
			// A local variable declared inside Main is not accessible in AnotherMethod.

			string anotherVariable = "I am local to AnotherMethod";

			// The line below throws an error, as "variable" is not an object AnotherMethod knows of.
			//Console.WriteLine(variable);

			if (true) {
				// If statement's scope starts here =================

				// The local variable "yetAnotherVariable" is this if statement.
				// Therefore, it is not accessible outside of this statement.
				string yetAnotherVariable = "I am accessible inside this if statement, but not outside of it.";

				// However, "anotherVariable" can be accessed in this scope.
				anotherVariable = "I can be accessed inside this if statement.";

				// If statement's scope ends here =================
			}

			classVariable = "I can be accessed here too.";

			// AnotherMethod's scope ends here =================
		}
	}
}

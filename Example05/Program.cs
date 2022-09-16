using System;

namespace Example05 {
	class Program {
		static void Main(string[] args) {
			/*
			
			Write a console application that performs any mathematical operation 
			between two user-provided numbers.
			 
			*/

			// STEP 1: Declaring variables.
			double firstNumber;
			double secondNumber;
			double result;

			// STEP 2: Collecting inputs.
			Console.WriteLine("Please provide two numbers to multiply.");
			Console.WriteLine("Enter the first number.");
			firstNumber = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter the second number.");
			secondNumber = double.Parse(Console.ReadLine());

			// STEP 3: Algorithm.
			result = firstNumber * secondNumber;

			// STEP 4: Display results:
			Console.WriteLine("\nThe result is:");
			Console.WriteLine(result);
		}
	}
}

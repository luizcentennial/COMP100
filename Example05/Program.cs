using System;

namespace Example05 {
	class Program {
		static void Main(string[] args) {
			/*
			
			Write a console application that performs any mathematical operation 
			between two user-provided numbers.
			 
			*/

			// STEP 01: Declaring variables.
			double firstNumber;
			double secondNumber;
			double total;

			// STEP 02: Collecting inputs.
			Console.WriteLine("Please provide two numbers to multiply.");
			Console.WriteLine("Enter the first number: ");
			firstNumber = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter the second number: ");
			secondNumber = double.Parse(Console.ReadLine());

			// STEP 03: Algorithm.
			total = firstNumber * secondNumber;

			// STEP 04: Displaying results.
			Console.WriteLine("\nThe result is: ");
			Console.WriteLine(total);
		}
	}
}

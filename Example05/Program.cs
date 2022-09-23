using System;

namespace Example05 {
	class Program {
		static void Main(string[] args) {
			/*
			
			Write a console application that performs a mathematical operation of your choice
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

		// IPO CHARTS
		// IPO Charts give you better visualization as to what the moving parts are in your system.
		// - Inputs;
		// - Processing (algorithm);
		// - Outputs.

		// =====================================================================================                                 ==================
		// |     INPUT      |                   PROCESSING                    |     OUTPUT     |
		// ====================================================================================|
		// |                |                                                 |                |                
		// | firstNumber    | 1. Collect value for firstNumber                | total          |                
		// | secondNumber   | 2. Store input in firstNumber                   |                |                
		// |                | 3. Collect value for secondNumber               |                |                
		// |                | 4. Store input in secondNumber                  |                |                
		// |                | 5. Calculate total per formula:                 |                |                
		// |                |    total = firstNumber * secondNumber           |                |                
		// |                | 6. Print total to console                       |                |                
		// |                |                                                 |                |                
		// |                |                                                 |                |                
		// |                |                                                 |                |
		// =====================================================================================
	}
}

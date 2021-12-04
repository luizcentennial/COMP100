using System;

namespace Exercise14 {
	class Program {
		static void Main(string[] args) {
			/*
			 
			Write a program that defines two methods.
			
			The first method, called GenerateArray
			generates an array of random integers. It
			takes in one integer parameter, which is the size
			of the array to be generated.

			The second method, called DisplayArray, 
			prints all array elements in the console,
			on the same line, separated by commas. 
			It takes in one integer array (the array to be displayed)
			as a parameter, and does not return anything.
			
			Test your methods by calling them in the Main method.
			
			*/

			int[] array = GenerateArray(10);

			DisplayArray(array);
		}

		public static int[] GenerateArray(uint size) {
			Random randomizer = new Random();
			int[] array = new int[size];

			for (int i = 0; i < array.Length; i++) {
				array[i] = randomizer.Next(100, 200);
			}

			return array;
		}

		public static void DisplayArray(int[] array) {
			foreach (int item in array) {
				Console.Write($"{item}, ");
			}

			Console.WriteLine('\n');
		}
	}
}

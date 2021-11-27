using System;

namespace Arrays {
	class Program {
		static void Main(string[] args) {
			// ARRAYS

			// This is how a regular local variable is declared.
			// We start with the data type, and then a variable name.
			// This type of object can only hold one value at a time.

			int number;
			string word;
			char letter = 'a';

			// Arrays, however, can hold multiple values at the same time.

			// To declare an array, we follow the same syntax structure.
			int[] numbers;

			// There are a few different ways to initialize arrays.

			// Declare and initialize at the same:
			// This method is ideal when all array elements are known.
			char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e' };
			// short hand: char[] letters = { 'a', 'b', 'c', 'd', 'e' };

			// Intialize after declaration.
			// This method is ideal when array elements are unknown at declaration time.
			// We start by initializing an empty array.
			string[] words = new string[3];

			// Once the empty array is available, we can initialize each individual slot.
			// We do that by referencing items by their indexes.
			words[0] = "Hello";
			words[1] = "C#";
			words[3] = "!";
		}
	}
}

using System;

namespace Example14 {
	class Program {
		static void Main(string[] args) {
			/*  
			 
			Write a console application that prompts the user to input the current ambient temperature.
			
			If the temperature is lower than 15, display a message "Too cold!".
			If the temperature is between 15 and 25, display a message "Perfect!".
			If the temperature is greater than 25, display a message "Too hot!".
			 
			*/

			Console.WriteLine("Please input the current ambient temperature: ");
			double temperature = double.Parse(Console.ReadLine());

			if (temperature < 15) {
				Console.WriteLine("Too cold!");
			}
			else if (temperature >= 15 && temperature <= 25) {
				Console.WriteLine("Perfect!");
			}
			else {
				Console.WriteLine("Too hot!");
			}
		}
	}
}

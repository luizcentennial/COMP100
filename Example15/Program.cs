using System;

namespace Example15 {
	class Program {
		static void Main(string[] args) {
			/*
			 
			Write a console app that prompts the user to input the planet they came from.
			
			If the input is "Earth", display a message "You are an earthling.".
			If the input is "Mars", display a message "You are a martian.".
			If the input is "Jupiter", display a message "You are a jupiterian.".
			For any unspecified planets, display a message "I do not know that planet.".
			
			*/

			Console.WriteLine("Please input the planet you came from:");
			string input = Console.ReadLine();

			switch (input.ToUpper()) {
				case "EARTH":
					Console.WriteLine("You are an earthling.");
					break;
				case "MARS":
					Console.WriteLine("You are a martian.");
					break;
				case "JUPITER":
					Console.WriteLine("You are a jupiterian.");
					break;
				default:
					Console.WriteLine("I do not know that planet.");
					break;
			}
		}
	}
}

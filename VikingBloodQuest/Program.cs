using System;
using GameLogic;

namespace VikingBloodQuest
{
	class Program
	{
		public static bool GameRunning = true;

		static void Main()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Welcome To");
			Console.WriteLine("____   ____.__ __   .__                 __________.__                    .___ ________                          __   ");
			Console.WriteLine("\\   \\ /   /|__|  | _|__| ____    ____   \\______   \\  |   ____   ____   __| _/ \\_____  \\  __ __   ____   _______/  |_ ");
			Console.WriteLine(" \\   Y   / |  |  |/ /  |/    \\  / ___\\   |    |  _/  |  /  _ \\ /  _ \\ / __ |   /  / \\  \\|  |  \\_/ __ \\ /  ___/\\   __\\");
			Console.WriteLine("  \\     /  |  |    <|  |   |  \\/ /_/  >  |    |   \\  |_(  <_> |  <_> ) /_/ |  /   \\_/.  \\  |  /\\  ___/ \\___ \\  |  |  ");
			Console.WriteLine("   \\___/   |__|__|_ \\__|___|  /\\___  /   |______  /____/\\____/ \\____/\\____ |  \\_____\\ \\_/____/  \\___  >____  > |__|  ");
			Console.WriteLine("                   \\/       \\//_____/           \\/                        \\/         \\__>           \\/     \\/        ");
			Console.ResetColor();
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("                           ___");
			Console.WriteLine("                          ( ((");
			Console.WriteLine("                           ) ))");
			Console.WriteLine("  .::.                    / /(");
			Console.WriteLine(" \'M .-;-.-.-.-.-.-.-.-.-/| ((::::::::::::::::::::::::::::::::::::::::::::::.._");
			Console.WriteLine("(J ( ( ( ( ( ( ( ( ( ( ( |  ))   -====================================-      _.>");
			Console.WriteLine(" `P `-;-`-`-`-`-`-`-`-`-\\| ((::::::::::::::::::::::::::::::::::::::::::::::\'\'");
			Console.WriteLine("  `::\'                    \\ \\(");
			Console.WriteLine("                           ) ))");
			Console.WriteLine("                          (_((");

			Console.WriteLine(GameApi.StartGame());

			while (GameRunning)
			{
				var commandProcessed = GameApi.ProcessCommand(Console.ReadLine());
				Console.WriteLine(commandProcessed.Item1);
				GameRunning = commandProcessed.Item2;
			}
			Console.ReadLine();
		}
	}
}

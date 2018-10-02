using System;
using System.Collections;
using System.ComponentModel;
using static GameLogic.GameEngine;

namespace GameLogic
{
	public class GameApi
	{
		internal static byte GameState;
		internal static bool GameRunning = true;

		public static string StartGame()
		{
			GameState = Convert.ToByte(0);
			return "Would you like to begin your quest? Yes or No?";
		}

		public static (string, bool) ProcessCommand(string input)
		{
			string output = "taco";
			switch (BitConverter.ToBoolean(new []{GameState}))
			{
				case false:
					(GameState, output, GameRunning) = GameSplash(GameState, input);
					return (output, GameRunning);
				default:
					return (output, true);
			}
		}
	}
}

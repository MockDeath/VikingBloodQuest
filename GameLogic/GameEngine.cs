using Microsoft.VisualBasic.CompilerServices;

namespace GameLogic
{
	public class GameEngine
	{
		internal static (byte, string, bool) GameSplash(byte gameState, string input)
		{


			bool running = true;
			string output = "not taco";
			return (gameState, output, running);
		}

		internal static (byte, string, bool) InputParse(byte gameState, string input)
		{
			bool running = true;
			string output = "not taco";
			return (gameState, output, running);
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTaskConsole
{
    static class GameMenu
    {
        private static GameModes gameMode;
        public enum GameModes
        {
            One,
            Two,
            Remove
        }

        public static GameModes GetCurrentGameMode()
        {
            return gameMode;
        }

        public static void SetCurrentGameMode()
        {
            char key = Console.ReadKey().KeyChar;
            if (key == '1')
            {
                gameMode = GameModes.One;
                Console.WriteLine();
                Console.WriteLine("1x1 selected");
            }
            else if(key == '2')
            {
                gameMode = GameModes.Two;
                Console.WriteLine();
                Console.WriteLine("2x2 selected");
            }
            else if(key == '0')
            {
                gameMode = GameModes.Remove;
                Console.WriteLine();
                Console.WriteLine("Remove selected");
            } 
            else 
            {
                Console.WriteLine();
                Console.WriteLine("di naxyi");
                SetCurrentGameMode();
            }
            Console.WriteLine($"___________________");
        }

        public static void ShowGameModes()
        {
            Console.WriteLine("Select game mode:");
            Console.WriteLine("1. Create 1x1");
            Console.WriteLine("2. Create 2x2");
            Console.WriteLine("0. Remove");
            Console.WriteLine($"___________________");
        }
    }
}
